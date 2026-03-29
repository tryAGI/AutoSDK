//HintName: G.Models.GraphNodeVariant8Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GraphNodeVariant8Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompt_template")]
        PromptTemplate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraphNodeVariant8TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraphNodeVariant8Type value)
        {
            return value switch
            {
                GraphNodeVariant8Type.PromptTemplate => "prompt_template",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraphNodeVariant8Type? ToEnum(string value)
        {
            return value switch
            {
                "prompt_template" => GraphNodeVariant8Type.PromptTemplate,
                _ => null,
            };
        }
    }
}