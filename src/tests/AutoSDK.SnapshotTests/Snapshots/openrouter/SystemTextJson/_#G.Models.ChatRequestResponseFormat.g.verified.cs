//HintName: G.Models.ChatRequestResponseFormat.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Response format configuration
    /// </summary>
    public readonly partial struct ChatRequestResponseFormat : global::System.IEquatable<ChatRequestResponseFormat>
    {
        /// <summary>
        /// Default text response format
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatFormatTextConfig? ChatFormatTextConfig { get; init; }
#else
        public global::G.ChatFormatTextConfig? ChatFormatTextConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatFormatTextConfig))]
#endif
        public bool IsChatFormatTextConfig => ChatFormatTextConfig != null;

        /// <summary>
        /// JSON object response format
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.FormatJsonObjectConfig? FormatJsonObjectConfig { get; init; }
#else
        public global::G.FormatJsonObjectConfig? FormatJsonObjectConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FormatJsonObjectConfig))]
#endif
        public bool IsFormatJsonObjectConfig => FormatJsonObjectConfig != null;

        /// <summary>
        /// JSON Schema response format for structured outputs
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatFormatJsonSchemaConfig? ChatFormatJsonSchemaConfig { get; init; }
#else
        public global::G.ChatFormatJsonSchemaConfig? ChatFormatJsonSchemaConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatFormatJsonSchemaConfig))]
#endif
        public bool IsChatFormatJsonSchemaConfig => ChatFormatJsonSchemaConfig != null;

        /// <summary>
        /// Custom grammar response format
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatFormatGrammarConfig? ChatFormatGrammarConfig { get; init; }
#else
        public global::G.ChatFormatGrammarConfig? ChatFormatGrammarConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatFormatGrammarConfig))]
#endif
        public bool IsChatFormatGrammarConfig => ChatFormatGrammarConfig != null;

        /// <summary>
        /// Python code response format
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.ChatFormatPythonConfig? ChatFormatPythonConfig { get; init; }
#else
        public global::G.ChatFormatPythonConfig? ChatFormatPythonConfig { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatFormatPythonConfig))]
#endif
        public bool IsChatFormatPythonConfig => ChatFormatPythonConfig != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestResponseFormat(global::G.ChatFormatTextConfig value) => new ChatRequestResponseFormat((global::G.ChatFormatTextConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatFormatTextConfig?(ChatRequestResponseFormat @this) => @this.ChatFormatTextConfig;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestResponseFormat(global::G.ChatFormatTextConfig? value)
        {
            ChatFormatTextConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestResponseFormat(global::G.FormatJsonObjectConfig value) => new ChatRequestResponseFormat((global::G.FormatJsonObjectConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.FormatJsonObjectConfig?(ChatRequestResponseFormat @this) => @this.FormatJsonObjectConfig;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestResponseFormat(global::G.FormatJsonObjectConfig? value)
        {
            FormatJsonObjectConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestResponseFormat(global::G.ChatFormatJsonSchemaConfig value) => new ChatRequestResponseFormat((global::G.ChatFormatJsonSchemaConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatFormatJsonSchemaConfig?(ChatRequestResponseFormat @this) => @this.ChatFormatJsonSchemaConfig;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestResponseFormat(global::G.ChatFormatJsonSchemaConfig? value)
        {
            ChatFormatJsonSchemaConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestResponseFormat(global::G.ChatFormatGrammarConfig value) => new ChatRequestResponseFormat((global::G.ChatFormatGrammarConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatFormatGrammarConfig?(ChatRequestResponseFormat @this) => @this.ChatFormatGrammarConfig;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestResponseFormat(global::G.ChatFormatGrammarConfig? value)
        {
            ChatFormatGrammarConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestResponseFormat(global::G.ChatFormatPythonConfig value) => new ChatRequestResponseFormat((global::G.ChatFormatPythonConfig?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.ChatFormatPythonConfig?(ChatRequestResponseFormat @this) => @this.ChatFormatPythonConfig;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestResponseFormat(global::G.ChatFormatPythonConfig? value)
        {
            ChatFormatPythonConfig = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestResponseFormat(
            global::G.ChatFormatTextConfig? chatFormatTextConfig,
            global::G.FormatJsonObjectConfig? formatJsonObjectConfig,
            global::G.ChatFormatJsonSchemaConfig? chatFormatJsonSchemaConfig,
            global::G.ChatFormatGrammarConfig? chatFormatGrammarConfig,
            global::G.ChatFormatPythonConfig? chatFormatPythonConfig
            )
        {
            ChatFormatTextConfig = chatFormatTextConfig;
            FormatJsonObjectConfig = formatJsonObjectConfig;
            ChatFormatJsonSchemaConfig = chatFormatJsonSchemaConfig;
            ChatFormatGrammarConfig = chatFormatGrammarConfig;
            ChatFormatPythonConfig = chatFormatPythonConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatFormatPythonConfig as object ??
            ChatFormatGrammarConfig as object ??
            ChatFormatJsonSchemaConfig as object ??
            FormatJsonObjectConfig as object ??
            ChatFormatTextConfig as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatFormatTextConfig?.ToString() ??
            FormatJsonObjectConfig?.ToString() ??
            ChatFormatJsonSchemaConfig?.ToString() ??
            ChatFormatGrammarConfig?.ToString() ??
            ChatFormatPythonConfig?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatFormatTextConfig && !IsFormatJsonObjectConfig && !IsChatFormatJsonSchemaConfig && !IsChatFormatGrammarConfig && !IsChatFormatPythonConfig || !IsChatFormatTextConfig && IsFormatJsonObjectConfig && !IsChatFormatJsonSchemaConfig && !IsChatFormatGrammarConfig && !IsChatFormatPythonConfig || !IsChatFormatTextConfig && !IsFormatJsonObjectConfig && IsChatFormatJsonSchemaConfig && !IsChatFormatGrammarConfig && !IsChatFormatPythonConfig || !IsChatFormatTextConfig && !IsFormatJsonObjectConfig && !IsChatFormatJsonSchemaConfig && IsChatFormatGrammarConfig && !IsChatFormatPythonConfig || !IsChatFormatTextConfig && !IsFormatJsonObjectConfig && !IsChatFormatJsonSchemaConfig && !IsChatFormatGrammarConfig && IsChatFormatPythonConfig;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.ChatFormatTextConfig?, TResult>? chatFormatTextConfig = null,
            global::System.Func<global::G.FormatJsonObjectConfig?, TResult>? formatJsonObjectConfig = null,
            global::System.Func<global::G.ChatFormatJsonSchemaConfig?, TResult>? chatFormatJsonSchemaConfig = null,
            global::System.Func<global::G.ChatFormatGrammarConfig?, TResult>? chatFormatGrammarConfig = null,
            global::System.Func<global::G.ChatFormatPythonConfig?, TResult>? chatFormatPythonConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatFormatTextConfig && chatFormatTextConfig != null)
            {
                return chatFormatTextConfig(ChatFormatTextConfig!);
            }
            else if (IsFormatJsonObjectConfig && formatJsonObjectConfig != null)
            {
                return formatJsonObjectConfig(FormatJsonObjectConfig!);
            }
            else if (IsChatFormatJsonSchemaConfig && chatFormatJsonSchemaConfig != null)
            {
                return chatFormatJsonSchemaConfig(ChatFormatJsonSchemaConfig!);
            }
            else if (IsChatFormatGrammarConfig && chatFormatGrammarConfig != null)
            {
                return chatFormatGrammarConfig(ChatFormatGrammarConfig!);
            }
            else if (IsChatFormatPythonConfig && chatFormatPythonConfig != null)
            {
                return chatFormatPythonConfig(ChatFormatPythonConfig!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.ChatFormatTextConfig?>? chatFormatTextConfig = null,
            global::System.Action<global::G.FormatJsonObjectConfig?>? formatJsonObjectConfig = null,
            global::System.Action<global::G.ChatFormatJsonSchemaConfig?>? chatFormatJsonSchemaConfig = null,
            global::System.Action<global::G.ChatFormatGrammarConfig?>? chatFormatGrammarConfig = null,
            global::System.Action<global::G.ChatFormatPythonConfig?>? chatFormatPythonConfig = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatFormatTextConfig)
            {
                chatFormatTextConfig?.Invoke(ChatFormatTextConfig!);
            }
            else if (IsFormatJsonObjectConfig)
            {
                formatJsonObjectConfig?.Invoke(FormatJsonObjectConfig!);
            }
            else if (IsChatFormatJsonSchemaConfig)
            {
                chatFormatJsonSchemaConfig?.Invoke(ChatFormatJsonSchemaConfig!);
            }
            else if (IsChatFormatGrammarConfig)
            {
                chatFormatGrammarConfig?.Invoke(ChatFormatGrammarConfig!);
            }
            else if (IsChatFormatPythonConfig)
            {
                chatFormatPythonConfig?.Invoke(ChatFormatPythonConfig!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatFormatTextConfig,
                typeof(global::G.ChatFormatTextConfig),
                FormatJsonObjectConfig,
                typeof(global::G.FormatJsonObjectConfig),
                ChatFormatJsonSchemaConfig,
                typeof(global::G.ChatFormatJsonSchemaConfig),
                ChatFormatGrammarConfig,
                typeof(global::G.ChatFormatGrammarConfig),
                ChatFormatPythonConfig,
                typeof(global::G.ChatFormatPythonConfig),
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
        public bool Equals(ChatRequestResponseFormat other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.ChatFormatTextConfig?>.Default.Equals(ChatFormatTextConfig, other.ChatFormatTextConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::G.FormatJsonObjectConfig?>.Default.Equals(FormatJsonObjectConfig, other.FormatJsonObjectConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatFormatJsonSchemaConfig?>.Default.Equals(ChatFormatJsonSchemaConfig, other.ChatFormatJsonSchemaConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatFormatGrammarConfig?>.Default.Equals(ChatFormatGrammarConfig, other.ChatFormatGrammarConfig) &&
                global::System.Collections.Generic.EqualityComparer<global::G.ChatFormatPythonConfig?>.Default.Equals(ChatFormatPythonConfig, other.ChatFormatPythonConfig) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatRequestResponseFormat obj1, ChatRequestResponseFormat obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatRequestResponseFormat>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatRequestResponseFormat obj1, ChatRequestResponseFormat obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatRequestResponseFormat o && Equals(o);
        }
    }
}
