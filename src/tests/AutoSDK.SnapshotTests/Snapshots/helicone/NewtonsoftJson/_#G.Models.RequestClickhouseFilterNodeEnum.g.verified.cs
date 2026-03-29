//HintName: G.Models.RequestClickhouseFilterNodeEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RequestClickhouseFilterNodeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="all")]
        All,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestClickhouseFilterNodeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestClickhouseFilterNodeEnum value)
        {
            return value switch
            {
                RequestClickhouseFilterNodeEnum.All => "all",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestClickhouseFilterNodeEnum? ToEnum(string value)
        {
            return value switch
            {
                "all" => RequestClickhouseFilterNodeEnum.All,
                _ => null,
            };
        }
    }
}