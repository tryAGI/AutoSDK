//HintName: G.Models.CreateEmbeddingsRequestModelName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The video understanding model to use. Only "marengo3.0" is supported.<br/>
    /// Default Value: marengo3.0
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateEmbeddingsRequestModelName
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="marengo3.0")]
        Marengo30,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEmbeddingsRequestModelNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEmbeddingsRequestModelName value)
        {
            return value switch
            {
                CreateEmbeddingsRequestModelName.Marengo30 => "marengo3.0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEmbeddingsRequestModelName? ToEnum(string value)
        {
            return value switch
            {
                "marengo3.0" => CreateEmbeddingsRequestModelName.Marengo30,
                _ => null,
            };
        }
    }
}