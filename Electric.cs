namespace VehicleCustomization
{
    public interface IElectric
    {
        void ChargeBattery();
        int CurrentChargePercentage { get; set; }

    }
}