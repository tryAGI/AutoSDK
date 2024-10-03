//HintName: G.Models.Vectorizer.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Vectorizer for this collection (e.g. `text2vec-transformers`). This will override any cluster-wide default set by an environment variable. &lt;br/&gt;&lt;br/&gt;If `none`, you must import a vector with each object yourself.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum Vectorizer
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="<vectorizer_module_name>")]
        x_vectorizerModuleName_,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VectorizerExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Vectorizer value)
        {
            return value switch
            {
                Vectorizer.None => "none",
                Vectorizer.x_vectorizerModuleName_ => "<vectorizer_module_name>",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Vectorizer? ToEnum(string value)
        {
            return value switch
            {
                "none" => Vectorizer.None,
                "<vectorizer_module_name>" => Vectorizer.x_vectorizerModuleName_,
                _ => null,
            };
        }
    }
}