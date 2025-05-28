namespace CatchUpPlatform.API.News.Interfaces.REST.Resources;

/// <summary>
/// Represents the data provided by the server about a favorite source. 
/// </summary>
/// <param name="Id">The server-generated ID</param>
/// <param name="NewsApiKey">The News API Key</param>
/// <param name="SourceId">The Source ID</param>
public record FavoriteSourceResource(int Id, string NewsApiKey, string SourceId);