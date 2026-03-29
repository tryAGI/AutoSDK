//HintName: G.Models.OpenAiGeneratedAssetOptions.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Generate assets using OpenAI provider AI services.<br/>
    /// The following AI generation services are available: &lt;ul&gt;<br/>
    ///   &lt;li&gt;&lt;a href="#tocs_openaitextgeneratoroptions"&gt;OpenAiTextGeneratorOptions&lt;/a&gt;&lt;/li&gt;<br/>
    /// &lt;/ul&gt;
    /// </summary>
    public readonly partial struct OpenAiGeneratedAssetOptions : global::System.IEquatable<OpenAiGeneratedAssetOptions>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.OpenAiGeneratedAssetOptionsDiscriminatorType? Type { get; }

        /// <summary>
        /// Options for the OpenAI text-generator service. Set a text prompt that will be used to generate a new body of text. The output will be generated as a text (txt) file available at the URL returned in the response.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.OpenAiTextGeneratorOptions? TextGenerator { get; init; }
#else
        public global::G.OpenAiTextGeneratorOptions? TextGenerator { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextGenerator))]
#endif
        public bool IsTextGenerator => TextGenerator != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator OpenAiGeneratedAssetOptions(global::G.OpenAiTextGeneratorOptions value) => new OpenAiGeneratedAssetOptions((global::G.OpenAiTextGeneratorOptions?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.OpenAiTextGeneratorOptions?(OpenAiGeneratedAssetOptions @this) => @this.TextGenerator;

        /// <summary>
        /// 
        /// </summary>
        public OpenAiGeneratedAssetOptions(global::G.OpenAiTextGeneratorOptions? value)
        {
            TextGenerator = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public OpenAiGeneratedAssetOptions(
            global::G.OpenAiGeneratedAssetOptionsDiscriminatorType? type,
            global::G.OpenAiTextGeneratorOptions? textGenerator
            )
        {
            Type = type;

            TextGenerator = textGenerator;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TextGenerator as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            TextGenerator?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsTextGenerator;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.OpenAiTextGeneratorOptions?, TResult>? textGenerator = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextGenerator && textGenerator != null)
            {
                return textGenerator(TextGenerator!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.OpenAiTextGeneratorOptions?>? textGenerator = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsTextGenerator)
            {
                textGenerator?.Invoke(TextGenerator!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                TextGenerator,
                typeof(global::G.OpenAiTextGeneratorOptions),
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
        public bool Equals(OpenAiGeneratedAssetOptions other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.OpenAiTextGeneratorOptions?>.Default.Equals(TextGenerator, other.TextGenerator) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(OpenAiGeneratedAssetOptions obj1, OpenAiGeneratedAssetOptions obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<OpenAiGeneratedAssetOptions>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(OpenAiGeneratedAssetOptions obj1, OpenAiGeneratedAssetOptions obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is OpenAiGeneratedAssetOptions o && Equals(o);
        }
    }
}
