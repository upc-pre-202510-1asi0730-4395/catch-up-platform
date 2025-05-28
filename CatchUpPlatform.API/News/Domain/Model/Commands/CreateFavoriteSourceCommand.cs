namespace CatchUpPlatform.API.News.Domain.Model.Commands;

/// <summary>
///     Command to create a favorite news source
/// </summary>
/// <param name="NewsApiKey">The NewsApiKey obtained from provider</param>
/// <param name="SourceId">The SourceId of the news source</param>
public record CreateFavoriteSourceCommand(string NewsApiKey, string SourceId);