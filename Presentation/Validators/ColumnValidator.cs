using System.ComponentModel.DataAnnotations;
using Data.Repositories;
using Presentation.ViewModels;

namespace Presentation.Validators;

public class ColumnValidator : ValidationAttribute
{
    public string GetErrorMessage() =>
        "Chosen column is outside the row range of the flight";

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        FlightDbRepository? _flightsRepository = (FlightDbRepository)validationContext.GetService(typeof(FlightDbRepository));
        if (_flightsRepository != null)
        {
            int? flightIdN = ((BookingVM)validationContext.ObjectInstance).FlightID;
            if (!flightIdN.HasValue)
            {
                return new ValidationResult("Cannot decide validity of column before choosing a flight");
            }
            int flightId = flightIdN.Value;
            var flight = _flightsRepository.GetFlight(flightId);
            if (flight != null && value != null)
            {
                if ((int)value >= 1 && (int)value <= flight.Columns)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult(GetErrorMessage());
                }
            }
            else
            {
                return new ValidationResult("Something went wrong while retrieving value from input");
            }
        }

        return new ValidationResult("Could not get the repository");
    }
}
