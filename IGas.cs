namespace VehicleCustomization
{
    public interface IGas
    {
        void RefuelTank();
        int CurrentTankPercentage { get; set; }

    }
}