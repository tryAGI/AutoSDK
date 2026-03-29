//HintName: G.Models.CreateDubbingProjectApiRequestFromSourceAssetIdVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The visibility of the dubbed video.<br/>
    /// Default Value: private<br/>
    /// Example: private
    /// </summary>
    public enum CreateDubbingProjectApiRequestFromSourceAssetIdVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDubbingProjectApiRequestFromSourceAssetIdVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDubbingProjectApiRequestFromSourceAssetIdVisibility value)
        {
            return value switch
            {
                CreateDubbingProjectApiRequestFromSourceAssetIdVisibility.Private => "private",
                CreateDubbingProjectApiRequestFromSourceAssetIdVisibility.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDubbingProjectApiRequestFromSourceAssetIdVisibility? ToEnum(string value)
        {
            return value switch
            {
                "private" => CreateDubbingProjectApiRequestFromSourceAssetIdVisibility.Private,
                "public" => CreateDubbingProjectApiRequestFromSourceAssetIdVisibility.Public,
                _ => null,
            };
        }
    }
}