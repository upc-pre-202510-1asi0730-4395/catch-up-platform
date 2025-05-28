namespace CatchUpPlatform.API.News.Domain.Model.Queries;

/// <summary>
///     Query to get a favorite source by ID
/// </summary>
/// <param name="Id">The Source ID to search</param>
public record GetFavoriteSourceByIdQuery(int Id);