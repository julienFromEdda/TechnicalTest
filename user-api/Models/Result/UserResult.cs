using UserApi.Models.Entity;

namespace UserApi.Models.Result;

public class UserResult
{
    public int TotalCount { get; set; }

    public IEnumerable<User>? Results { get; set; }
}
