namespace _01.StreamProgress.Models.Interfaces
{
    public interface IStreamable
    {
        int Length { get; set; }

        int BytesSent { get; set; }
    }
}
