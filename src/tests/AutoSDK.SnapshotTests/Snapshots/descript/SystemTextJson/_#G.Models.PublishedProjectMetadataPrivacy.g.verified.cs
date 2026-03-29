//HintName: G.Models.PublishedProjectMetadataPrivacy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The access permission level for this published project<br/>
    /// Example: unlisted
    /// </summary>
    public enum PublishedProjectMetadataPrivacy
    {
        /// <summary>
        /// 
        /// </summary>
        Drive,
        /// <summary>
        /// 
        /// </summary>
        Password,
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Unlisted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublishedProjectMetadataPrivacyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublishedProjectMetadataPrivacy value)
        {
            return value switch
            {
                PublishedProjectMetadataPrivacy.Drive => "drive",
                PublishedProjectMetadataPrivacy.Password => "password",
                PublishedProjectMetadataPrivacy.Private => "private",
                PublishedProjectMetadataPrivacy.Public => "public",
                PublishedProjectMetadataPrivacy.Unlisted => "unlisted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublishedProjectMetadataPrivacy? ToEnum(string value)
        {
            return value switch
            {
                "drive" => PublishedProjectMetadataPrivacy.Drive,
                "password" => PublishedProjectMetadataPrivacy.Password,
                "private" => PublishedProjectMetadataPrivacy.Private,
                "public" => PublishedProjectMetadataPrivacy.Public,
                "unlisted" => PublishedProjectMetadataPrivacy.Unlisted,
                _ => null,
            };
        }
    }
}