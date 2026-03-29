//HintName: G.Models.CreateDubbingProjectApiRequestFromSourceVideoUrlVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The visibility of the dubbed video.<br/>
    /// Default Value: private<br/>
    /// Example: private
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateDubbingProjectApiRequestFromSourceVideoUrlVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDubbingProjectApiRequestFromSourceVideoUrlVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDubbingProjectApiRequestFromSourceVideoUrlVisibility value)
        {
            return value switch
            {
                CreateDubbingProjectApiRequestFromSourceVideoUrlVisibility.Private => "private",
                CreateDubbingProjectApiRequestFromSourceVideoUrlVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDubbingProjectApiRequestFromSourceVideoUrlVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreateDubbingProjectApiRequestFromSourceVideoUrlVisibility.Private,
                "public" => CreateDubbingProjectApiRequestFromSourceVideoUrlVisibility.Public,
                _ => null,
            };
        }
    }
}