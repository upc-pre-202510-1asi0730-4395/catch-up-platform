using CatchUpPlatform.API.News.Domain.Model.Aggregates;
using CatchUpPlatform.API.News.Domain.Model.Queries;

namespace CatchUpPlatform.API.News.Domain.Services;

/// <summary>
///     Interface for the FavoriteSourceQueryService.
/// </summary>
/// <remarks>
///     This interface defines the basic operations for the FavoriteSourceQueryService.
/// </remarks>
public interface IFavoriteSourceQueryService
{
    /// <summary>
    ///     Handle the GetAllFavoriteSourcesByNewsApiKeyQuery.
    /// </summary>
    /// <remarks>
    ///     This method handles the GetAllFavoriteSourcesByNewsApiKeyQuery. It returns all the favorite sources for the given
    ///     NewsApiKey.
    /// </remarks>
    /// <param name="query">The GetAllFavoriteSourcesByNewsApiKeyQuery query</param>
    /// <returns>An IEnumerable containing the FavoriteSource objects</returns>
    Task<IEnumerable<FavoriteSource>> Handle(GetAllFavoriteSourcesByNewsApiKeyQuery query);

    /// <summary>
    ///     Handle the GetFavoriteSourceByNewsApiKeyAndSourceIdQuery.
    /// </summary>
    /// <remarks>
    ///     This method handles the GetFavoriteSourceByNewsApiKeyAndSourceIdQuery. It returns the favorite source for the given
    ///     NewsApiKey and SourceId.
    /// </remarks>
    /// <param name="query">The GetFavoriteSourceByNewsApiKeyAndSourceIdQuery query</param>
    /// <returns>The FavoriteSource object if found, or null otherwise</returns>
    Task<FavoriteSource?> Handle(GetFavoriteSourceByNewsApiKeyAndSourceIdQuery query);

    /// <summary>
    ///     Handle the GetFavoriteSourceByIdQuery.
    /// </summary>
    /// <remarks>
    ///     This method handles the GetFavoriteSourceByIdQuery. It returns the favorite source for the given Id.
    /// </remarks>
    /// <param name="query">The GetFavoriteSourceIdQuery query</param>
    /// <returns>
    ///     The FavoriteSource object if found, or null otherwise
    /// </returns>
    Task<FavoriteSource?> Handle(GetFavoriteSourceByIdQuery query);
}