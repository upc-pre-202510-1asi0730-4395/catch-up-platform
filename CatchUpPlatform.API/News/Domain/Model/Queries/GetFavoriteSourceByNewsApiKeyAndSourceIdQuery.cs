namespace CatchUpPlatform.API.News.Domain.Model.Queries;

/// <summary>
///     Query to get a favorite source by NewsApiKey and SourceId
/// </summary>
/// <param name="NewsApiKey">The NewsApiKey to search</param>
/// <param name="SourceId">The Source ID to search</param>
public record GetFavoriteSourceByNewsApiKeyAndSourceIdQuery(string NewsApiKey, string SourceId);