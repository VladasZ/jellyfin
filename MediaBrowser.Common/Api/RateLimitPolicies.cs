namespace MediaBrowser.Common.Api;

/// <summary>
/// Policies for the API rate limiting.
/// </summary>
public static class RateLimitPolicies
{
    /// <summary>
    /// Policy name for the login endpoints, a small budget of attempts per client ip.
    /// </summary>
    public const string Login = "Login";
}
