namespace TankYouVeryMuch.Models.Dto.WotDto;

public class DefaultWotResponse<TModel> where TModel : class
{
    public string Status { get; set; }
    public WotMetaResponse Meta { get; set; }
    public TModel Data { get; set; }
}