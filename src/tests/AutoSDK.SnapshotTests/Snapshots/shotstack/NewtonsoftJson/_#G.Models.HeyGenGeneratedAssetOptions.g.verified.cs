//HintName: G.Models.HeyGenGeneratedAssetOptions.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Generate assets using the third party HeyGen provider AI services.<br/>
    /// The following AI generation services are available: &lt;ul&gt;<br/>
    ///   &lt;li&gt;&lt;a href="#tocs_heygentexttoavataroptions"&gt;HeyGenTextToAvatarOptions&lt;/a&gt;&lt;/li&gt;<br/>
    /// &lt;/ul&gt;
    /// </summary>
    public readonly partial struct HeyGenGeneratedAssetOptions : global::System.IEquatable<HeyGenGeneratedAssetOptions>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.HeyGenGeneratedAssetOptionsDiscriminatorType? Type { get; }

        /// <summary>
        /// Options for the HeyGen text-to-avatar service. Set the text to be converted to an avatar and configure the avatars voice, speaking style, appearance and background. The output will be generated as an MP4 video file available at the URL returned in the response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.HeyGenTextToAvatarOptions? TextToAvatar { get; init; }
#else
        public global::G.HeyGenTextToAvatarOptions? TextToAvatar { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToAvatar))]
#endif
        public bool IsTextToAvatar => TextToAvatar != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator HeyGenGeneratedAssetOptions(global::G.HeyGenTextToAvatarOptions value) => new HeyGenGeneratedAssetOptions((global::G.HeyGenTextToAvatarOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.HeyGenTextToAvatarOptions?(HeyGenGeneratedAssetOptions @this) => @this.TextToAvatar;

        /// <summary>
        /// 
        /// </summary>
        public HeyGenGeneratedAssetOptions(global::G.HeyGenTextToAvatarOptions? value)
        {
            TextToAvatar = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public HeyGenGeneratedAssetOptions(
            global::G.HeyGenGeneratedAssetOptionsDiscriminatorType? type,
            global::G.HeyGenTextToAvatarOptions? textToAvatar
            )
        {
            Type = type;

            TextToAvatar = textToAvatar;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TextToAvatar as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextToAvatar?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextToAvatar;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.HeyGenTextToAvatarOptions?, TResult>? textToAvatar = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextToAvatar && textToAvatar != null)
            {
                return textToAvatar(TextToAvatar!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.HeyGenTextToAvatarOptions?>? textToAvatar = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextToAvatar)
            {
                textToAvatar?.Invoke(TextToAvatar!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextToAvatar,
                typeof(global::G.HeyGenTextToAvatarOptions),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(HeyGenGeneratedAssetOptions other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.HeyGenTextToAvatarOptions?>.Default.Equals(TextToAvatar, other.TextToAvatar) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(HeyGenGeneratedAssetOptions obj1, HeyGenGeneratedAssetOptions obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<HeyGenGeneratedAssetOptions>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(HeyGenGeneratedAssetOptions obj1, HeyGenGeneratedAssetOptions obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is HeyGenGeneratedAssetOptions o && Equals(o);
        }
    }
}
