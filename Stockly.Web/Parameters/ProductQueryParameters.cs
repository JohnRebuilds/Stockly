namespace Stockly.Web.Parameters;

public record ProductQueryParameters(string Filter = "", int PageNumber = 1, int PageSize = 20);
