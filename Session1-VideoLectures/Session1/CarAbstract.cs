
public abstract class CarAbstract {
    public string SerialNumber { get; set; }
    public virtual string GetDetails() {
        string details = $"SerialNumber: {SerialNumber}";
        return details;
    }
}