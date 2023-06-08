namespace TankYouVeryMuch.Models.Dto.WotDto;

public class DefaultWotResponse<TModel> where TModel : class
{
    public string Status { get; set; }
    public WotMetaResponse Meta { get; set; }
    public List<TModel> Data { get; set; }
}