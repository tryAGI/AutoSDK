//HintName: G.Models.DisplayAdDisplayTo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Potentially limits visitors to whom the ad is visible<br/>
    /// Default Value: all
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DisplayAdDisplayTo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="logged_in")]
        LoggedIn,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="logged_out")]
        LoggedOut,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DisplayAdDisplayToExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DisplayAdDisplayTo value)
        {
            return value switch
            {
                DisplayAdDisplayTo.All => "all",
                DisplayAdDisplayTo.LoggedIn => "logged_in",
                DisplayAdDisplayTo.LoggedOut => "logged_out",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DisplayAdDisplayTo? ToEnum(string value)
        {
            return value switch
            {
                "all" => DisplayAdDisplayTo.All,
                "logged_in" => DisplayAdDisplayTo.LoggedIn,
                "logged_out" => DisplayAdDisplayTo.LoggedOut,
                _ => null,
            };
        }
    }
}