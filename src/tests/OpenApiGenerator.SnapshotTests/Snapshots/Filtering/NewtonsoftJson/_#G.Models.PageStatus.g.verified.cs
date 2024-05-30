//HintName: G.Models.PageStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The status of the most recent build of the Page.
    /// <br/>Example: built
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PageStatus
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="built")]
        Built,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="building")]
        Building,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="errored")]
        Errored,
    }

    public static class PageStatusExtensions
    {
        public static string ToValueString(this PageStatus value)
        {
            return value switch
            {
                PageStatus.Built => "built",
                PageStatus.Building => "building",
                PageStatus.Errored => "errored",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static PageStatus ToEnum(string value)
        {
            return value switch
            {
                "built" => PageStatus.Built,
                "building" => PageStatus.Building,
                "errored" => PageStatus.Errored,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static PageStatus ToEnum(int value)
        {
            return value switch
            {
                0 => PageStatus.Built,
                1 => PageStatus.Building,
                2 => PageStatus.Errored,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}