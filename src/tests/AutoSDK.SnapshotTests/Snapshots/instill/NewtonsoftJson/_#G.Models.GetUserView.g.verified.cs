//HintName: G.Models.GetUserView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetUserView
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_BASIC")]
        VIEWBASIC,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VIEW_FULL")]
        VIEWFULL,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetUserViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUserView value)
        {
            return value switch
            {
                GetUserView.VIEWBASIC => "VIEW_BASIC",
                GetUserView.VIEWFULL => "VIEW_FULL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUserView? ToEnum(string value)
        {
            return value switch
            {
                "VIEW_BASIC" => GetUserView.VIEWBASIC,
                "VIEW_FULL" => GetUserView.VIEWFULL,
                _ => null,
            };
        }
    }
}