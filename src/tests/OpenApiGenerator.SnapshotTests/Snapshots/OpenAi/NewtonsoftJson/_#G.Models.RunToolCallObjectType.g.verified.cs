//HintName: G.Models.RunToolCallObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool call the output is required for. For now, this is always `function`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RunToolCallObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
    }

    public static class RunToolCallObjectTypeExtensions
    {
        public static string ToValueString(this RunToolCallObjectType value)
        {
            return value switch
            {
                RunToolCallObjectType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunToolCallObjectType ToEnum(string value)
        {
            return value switch
            {
                "function" => RunToolCallObjectType.Function,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static RunToolCallObjectType ToEnum(int value)
        {
            return value switch
            {
                0 => RunToolCallObjectType.Function,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}