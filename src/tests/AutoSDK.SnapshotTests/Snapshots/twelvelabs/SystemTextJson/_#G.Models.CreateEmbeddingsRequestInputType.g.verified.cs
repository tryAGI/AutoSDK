//HintName: G.Models.CreateEmbeddingsRequestInputType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of content for the embeddings.<br/>
    /// **Values**:<br/>
    /// - `audio`: Creates embeddings for an audio file<br/>
    /// - `video`: Creates embeddings for a video file<br/>
    /// - `image`: Creates embeddings for an image file<br/>
    /// - `text`: Creates embeddings for text input<br/>
    /// - `text_image`: Creates embeddings for text and an image<br/>
    /// - `multi_input`: Creates a single embedding from up to 10 images. You can optionally include text to provide context. To reference specific images in your text, use placeholders in the following format: `&lt;@name&gt;`, where `name` matches the `name` field of a media source
    /// </summary>
    public enum CreateEmbeddingsRequestInputType
    {
        /// <summary>
        /// Creates embeddings for an audio file
        /// </summary>
        Audio,
        /// <summary>
        /// Creates embeddings for an image file
        /// </summary>
        Image,
        /// <summary>
        /// Creates a single embedding from up to 10 images. You can optionally include text to provide context. To reference specific images in your text, use placeholders in the following format: `&lt;@name&gt;`, where `name` matches the `name` field of a media source
        /// </summary>
        MultiInput,
        /// <summary>
        /// Creates embeddings for text input
        /// </summary>
        Text,
        /// <summary>
        /// Creates embeddings for text and an image
        /// </summary>
        TextImage,
        /// <summary>
        /// Creates embeddings for a video file
        /// </summary>
        Video,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateEmbeddingsRequestInputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateEmbeddingsRequestInputType value)
        {
            return value switch
            {
                CreateEmbeddingsRequestInputType.Audio => "audio",
                CreateEmbeddingsRequestInputType.Image => "image",
                CreateEmbeddingsRequestInputType.MultiInput => "multi_input",
                CreateEmbeddingsRequestInputType.Text => "text",
                CreateEmbeddingsRequestInputType.TextImage => "text_image",
                CreateEmbeddingsRequestInputType.Video => "video",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateEmbeddingsRequestInputType? ToEnum(string value)
        {
            return value switch
            {
                "audio" => CreateEmbeddingsRequestInputType.Audio,
                "image" => CreateEmbeddingsRequestInputType.Image,
                "multi_input" => CreateEmbeddingsRequestInputType.MultiInput,
                "text" => CreateEmbeddingsRequestInputType.Text,
                "text_image" => CreateEmbeddingsRequestInputType.TextImage,
                "video" => CreateEmbeddingsRequestInputType.Video,
                _ => null,
            };
        }
    }
}