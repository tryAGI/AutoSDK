//HintName: G.Models.LemurResponse.g.cs
using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct LemurResponse : global::System.IEquatable<LemurResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LemurStringResponse? String { get; init; }
#else
        public global::G.LemurStringResponse? String { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(String))]
#endif
        public bool IsString => String != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LemurResponse(global::G.LemurStringResponse value) => new LemurResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LemurStringResponse?(LemurResponse @this) => @this.String;

        /// <summary>
        /// 
        /// </summary>
        public LemurResponse(global::G.LemurStringResponse? value)
        {
            String = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.LemurQuestionAnswerResponse? QuestionAnswer { get; init; }
#else
        public global::G.LemurQuestionAnswerResponse? QuestionAnswer { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(QuestionAnswer))]
#endif
        public bool IsQuestionAnswer => QuestionAnswer != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator LemurResponse(global::G.LemurQuestionAnswerResponse value) => new LemurResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.LemurQuestionAnswerResponse?(LemurResponse @this) => @this.QuestionAnswer;

        /// <summary>
        /// 
        /// </summary>
        public LemurResponse(global::G.LemurQuestionAnswerResponse? value)
        {
            QuestionAnswer = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public LemurResponse(
            global::G.LemurStringResponse? @string,
            global::G.LemurQuestionAnswerResponse? questionAnswer
            )
        {
            String = @string;
            QuestionAnswer = questionAnswer;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            QuestionAnswer as object ??
            String as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsString && !IsQuestionAnswer || !IsString && IsQuestionAnswer;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.LemurStringResponse?, TResult>? @string = null,
            global::System.Func<global::G.LemurQuestionAnswerResponse?, TResult>? questionAnswer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString && @string != null)
            {
                return @string(String!);
            }
            else if (IsQuestionAnswer && questionAnswer != null)
            {
                return questionAnswer(QuestionAnswer!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.LemurStringResponse?>? @string = null,
            global::System.Action<global::G.LemurQuestionAnswerResponse?>? questionAnswer = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsString)
            {
                @string?.Invoke(String!);
            }
            else if (IsQuestionAnswer)
            {
                questionAnswer?.Invoke(QuestionAnswer!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                String,
                typeof(global::G.LemurStringResponse),
                QuestionAnswer,
                typeof(global::G.LemurQuestionAnswerResponse),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(LemurResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.LemurStringResponse?>.Default.Equals(String, other.String) &&
                global::System.Collections.Generic.EqualityComparer<global::G.LemurQuestionAnswerResponse?>.Default.Equals(QuestionAnswer, other.QuestionAnswer) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(LemurResponse obj1, LemurResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<LemurResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(LemurResponse obj1, LemurResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is LemurResponse o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.LemurResponse? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.LemurResponse>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.LemurResponse?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.LemurResponse?>(serializer.Deserialize<global::G.LemurResponse>(jsonReader));
        }

    }
}
