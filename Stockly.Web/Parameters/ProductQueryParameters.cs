namespace Stockly.Web.Parameters;

public record ProductQueryParameters(string SearchTerm = "", int PageNumber = 1, int PageSize = 15);
