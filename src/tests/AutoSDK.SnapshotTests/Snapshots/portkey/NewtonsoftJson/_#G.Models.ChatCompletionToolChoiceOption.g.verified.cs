//HintName: G.Models.ChatCompletionToolChoiceOption.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Controls which (if any) tool is called by the model.<br/>
    /// `none` means the model will not call any tool and instead generates a message.<br/>
    /// `auto` means the model can pick between generating a message or calling one or more tools.<br/>
    /// `required` means the model must call one or more tools.<br/>
    /// Specifying a particular tool via `{"type": "function", "function": {"name": "my_function"}}` forces the model to call that tool.<br/>
    /// `none` is the default when no tools are present. `auto` is the default if tools are present.
    /// </summary>
    public readonly partial struct ChatCompletionToolChoiceOption : global::System.IEquatable<ChatCompletionToolChoiceOption>
    {
        /// <summary>
        /// `none` means the model will not call any tool and instead generates a message. `auto` means the model can pick between generating a message or calling one or more tools. `required` means the model must call one or more tools.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionToolChoiceOptionEnum? Enum { get; init; }
#else
        public global::G.ChatCompletionToolChoiceOptionEnum? Enum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Enum))]
#endif
        public bool IsEnum => Enum != null;

        /// <summary>
        /// Specifies a tool the model should use. Use to force the model to call a specific function.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatCompletionNamedToolChoice? Named { get; init; }
#else
        public global::G.ChatCompletionNamedToolChoice? Named { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Named))]
#endif
        public bool IsNamed => Named != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionToolChoiceOption(global::G.ChatCompletionToolChoiceOptionEnum value) => new ChatCompletionToolChoiceOption((global::G.ChatCompletionToolChoiceOptionEnum?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionToolChoiceOptionEnum?(ChatCompletionToolChoiceOption @this) => @this.Enum;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionToolChoiceOption(global::G.ChatCompletionToolChoiceOptionEnum? value)
        {
            Enum = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatCompletionToolChoiceOption(global::G.ChatCompletionNamedToolChoice value) => new ChatCompletionToolChoiceOption((global::G.ChatCompletionNamedToolChoice?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatCompletionNamedToolChoice?(ChatCompletionToolChoiceOption @this) => @this.Named;

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionToolChoiceOption(global::G.ChatCompletionNamedToolChoice? value)
        {
            Named = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatCompletionToolChoiceOption(
            global::G.ChatCompletionToolChoiceOptionEnum? @enum,
            global::G.ChatCompletionNamedToolChoice? named
            )
        {
            Enum = @enum;
            Named = named;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Named as object ??
            Enum as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Enum?.ToValueString() ??
            Named?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsEnum && !IsNamed || !IsEnum && IsNamed;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatCompletionToolChoiceOptionEnum?, TResult>? @enum = null,
            global::System.Func<global::G.ChatCompletionNamedToolChoice?, TResult>? named = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum && @enum != null)
            {
                return @enum(Enum!);
            }
            else if (IsNamed && named != null)
            {
                return named(Named!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatCompletionToolChoiceOptionEnum?>? @enum = null,
            global::System.Action<global::G.ChatCompletionNamedToolChoice?>? named = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsEnum)
            {
                @enum?.Invoke(Enum!);
            }
            else if (IsNamed)
            {
                named?.Invoke(Named!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Enum,
                typeof(global::G.ChatCompletionToolChoiceOptionEnum),
                Named,
                typeof(global::G.ChatCompletionNamedToolChoice),
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
        public bool Equals(ChatCompletionToolChoiceOption other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionToolChoiceOptionEnum?>.Default.Equals(Enum, other.Enum) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatCompletionNamedToolChoice?>.Default.Equals(Named, other.Named) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatCompletionToolChoiceOption obj1, ChatCompletionToolChoiceOption obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatCompletionToolChoiceOption>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatCompletionToolChoiceOption obj1, ChatCompletionToolChoiceOption obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatCompletionToolChoiceOption o && Equals(o);
        }
    }
}
