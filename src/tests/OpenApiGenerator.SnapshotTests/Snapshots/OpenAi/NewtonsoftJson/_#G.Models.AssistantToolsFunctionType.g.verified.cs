//HintName: G.Models.AssistantToolsFunctionType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of tool being defined: `function`
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AssistantToolsFunctionType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="function")]
        Function,
    }

    public static class AssistantToolsFunctionTypeExtensions
    {
        public static string ToValueString(this AssistantToolsFunctionType value)
        {
            return value switch
            {
                AssistantToolsFunctionType.Function => "function",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static AssistantToolsFunctionType ToEnum(string value)
        {
            return value switch
            {
                "function" => AssistantToolsFunctionType.Function,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static AssistantToolsFunctionType ToEnum(int value)
        {
            return value switch
            {
                0 => AssistantToolsFunctionType.Function,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}