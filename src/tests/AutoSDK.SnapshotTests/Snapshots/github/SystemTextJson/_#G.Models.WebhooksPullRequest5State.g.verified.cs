//HintName: G.Models.WebhooksPullRequest5State.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of this Pull Request. Either `open` or `closed`.
    /// </summary>
    public enum WebhooksPullRequest5State
    {
        /// <summary>
        /// 
        /// </summary>
        Closed,
        /// <summary>
        /// 
        /// </summary>
        Open,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhooksPullRequest5StateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhooksPullRequest5State value)
        {
            return value switch
            {
                WebhooksPullRequest5State.Closed => "closed",
                WebhooksPullRequest5State.Open => "open",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhooksPullRequest5State? ToEnum(string value)
        {
            return value switch
            {
                "closed" => WebhooksPullRequest5State.Closed,
                "open" => WebhooksPullRequest5State.Open,
                _ => null,
            };
        }
    }
}