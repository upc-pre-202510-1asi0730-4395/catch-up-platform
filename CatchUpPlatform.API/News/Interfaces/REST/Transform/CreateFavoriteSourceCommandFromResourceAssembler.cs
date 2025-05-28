using CatchUpPlatform.API.News.Domain.Model.Commands;
using CatchUpPlatform.API.News.Interfaces.REST.Resources;

namespace CatchUpPlatform.API.News.Interfaces.REST.Transform;

/// <summary>
/// Assembles a CreateFavoriteSourceCommand from a CreateFavoriteSourceResource. 
/// </summary>
public static class CreateFavoriteSourceCommandFromResourceAssembler
{
    /// <summary>
    /// Assembles a CreateFavoriteSourceCommand from a CreateFavoriteSourceResource. 
    /// </summary>
    /// <param name="resource">The CreateFavoriteSourceResource resource</param>
    /// <returns>
    /// A CreateFavoriteSourceCommand assembled from the CreateFavoriteSourceResource
    /// </returns>
    public static CreateFavoriteSourceCommand ToCommandFromResource(CreateFavoriteSourceResource resource) =>
        new CreateFavoriteSourceCommand(resource.NewsApiKey, resource.SourceId);  
}