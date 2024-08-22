using System.Globalization;

namespace OOPSample.Shared.Domain.Model.ValueObjects;

public record Address(string Street, string Number, string City, string State, string Zipcode, string Country)
{
    public string AddressAsString => $"{Street} {Number}, {City}, {State}, {Zipcode}, {Country}";
}