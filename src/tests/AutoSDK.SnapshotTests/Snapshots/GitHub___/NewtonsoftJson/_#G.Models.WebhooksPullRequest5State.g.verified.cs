//HintName: G.Models.WebhooksPullRequest5State.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// State of this Pull Request. Either `open` or `closed`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebhooksPullRequest5State
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open")]
        Open,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="closed")]
        Closed,
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
                WebhooksPullRequest5State.Open => "open",
                WebhooksPullRequest5State.Closed => "closed",
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
                "open" => WebhooksPullRequest5State.Open,
                "closed" => WebhooksPullRequest5State.Closed,
                _ => null,
            };
        }
    }
}