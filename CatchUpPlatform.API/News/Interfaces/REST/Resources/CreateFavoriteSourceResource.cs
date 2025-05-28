namespace CatchUpPlatform.API.News.Interfaces.REST.Resources;

/// <summary>
/// Represents the data required to create a favorite source. 
/// </summary>
/// <param name="NewsApiKey">The News API Key</param>
/// <param name="SourceId">The Source ID</param>
public record CreateFavoriteSourceResource(string NewsApiKey, string SourceId);