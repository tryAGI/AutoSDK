//HintName: G.Models.ExampleListOrder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ExampleListOrder
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="recent")]
        Recent,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="random")]
        Random,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="recently_created")]
        RecentlyCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExampleListOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExampleListOrder value)
        {
            return value switch
            {
                ExampleListOrder.Recent => "recent",
                ExampleListOrder.Random => "random",
                ExampleListOrder.RecentlyCreated => "recently_created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExampleListOrder? ToEnum(string value)
        {
            return value switch
            {
                "recent" => ExampleListOrder.Recent,
                "random" => ExampleListOrder.Random,
                "recently_created" => ExampleListOrder.RecentlyCreated,
                _ => null,
            };
        }
    }
}