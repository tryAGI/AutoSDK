//HintName: G.Models.ChatRequestImageConfig.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ChatRequestImageConfig : global::System.IEquatable<ChatRequestImageConfig>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public string? ChatRequestImageConfigVariant1 { get; init; }
#else
        public string? ChatRequestImageConfigVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatRequestImageConfigVariant1))]
#endif
        public bool IsChatRequestImageConfigVariant1 => ChatRequestImageConfigVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public double? ChatRequestImageConfigVariant2 { get; init; }
#else
        public double? ChatRequestImageConfigVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatRequestImageConfigVariant2))]
#endif
        public bool IsChatRequestImageConfigVariant2 => ChatRequestImageConfigVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<object>? ChatRequestImageConfigVariant3 { get; init; }
#else
        public global::System.Collections.Generic.IList<object>? ChatRequestImageConfigVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatRequestImageConfigVariant3))]
#endif
        public bool IsChatRequestImageConfigVariant3 => ChatRequestImageConfigVariant3 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestImageConfig(string value) => new ChatRequestImageConfig((string?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator string?(ChatRequestImageConfig @this) => @this.ChatRequestImageConfigVariant1;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestImageConfig(string? value)
        {
            ChatRequestImageConfigVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ChatRequestImageConfig(double value) => new ChatRequestImageConfig((double?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator double?(ChatRequestImageConfig @this) => @this.ChatRequestImageConfigVariant2;

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestImageConfig(double? value)
        {
            ChatRequestImageConfigVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ChatRequestImageConfig(
            string? chatRequestImageConfigVariant1,
            double? chatRequestImageConfigVariant2,
            global::System.Collections.Generic.IList<object>? chatRequestImageConfigVariant3
            )
        {
            ChatRequestImageConfigVariant1 = chatRequestImageConfigVariant1;
            ChatRequestImageConfigVariant2 = chatRequestImageConfigVariant2;
            ChatRequestImageConfigVariant3 = chatRequestImageConfigVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ChatRequestImageConfigVariant3 as object ??
            ChatRequestImageConfigVariant2 as object ??
            ChatRequestImageConfigVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            ChatRequestImageConfigVariant1?.ToString() ??
            ChatRequestImageConfigVariant2?.ToString() ??
            ChatRequestImageConfigVariant3?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsChatRequestImageConfigVariant1 && !IsChatRequestImageConfigVariant2 && !IsChatRequestImageConfigVariant3 || !IsChatRequestImageConfigVariant1 && IsChatRequestImageConfigVariant2 && !IsChatRequestImageConfigVariant3 || !IsChatRequestImageConfigVariant1 && !IsChatRequestImageConfigVariant2 && IsChatRequestImageConfigVariant3;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<string?, TResult>? chatRequestImageConfigVariant1 = null,
            global::System.Func<double?, TResult>? chatRequestImageConfigVariant2 = null,
            global::System.Func<global::System.Collections.Generic.IList<object>?, TResult>? chatRequestImageConfigVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatRequestImageConfigVariant1 && chatRequestImageConfigVariant1 != null)
            {
                return chatRequestImageConfigVariant1(ChatRequestImageConfigVariant1!);
            }
            else if (IsChatRequestImageConfigVariant2 && chatRequestImageConfigVariant2 != null)
            {
                return chatRequestImageConfigVariant2(ChatRequestImageConfigVariant2!);
            }
            else if (IsChatRequestImageConfigVariant3 && chatRequestImageConfigVariant3 != null)
            {
                return chatRequestImageConfigVariant3(ChatRequestImageConfigVariant3!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<string?>? chatRequestImageConfigVariant1 = null,
            global::System.Action<double?>? chatRequestImageConfigVariant2 = null,
            global::System.Action<global::System.Collections.Generic.IList<object>?>? chatRequestImageConfigVariant3 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsChatRequestImageConfigVariant1)
            {
                chatRequestImageConfigVariant1?.Invoke(ChatRequestImageConfigVariant1!);
            }
            else if (IsChatRequestImageConfigVariant2)
            {
                chatRequestImageConfigVariant2?.Invoke(ChatRequestImageConfigVariant2!);
            }
            else if (IsChatRequestImageConfigVariant3)
            {
                chatRequestImageConfigVariant3?.Invoke(ChatRequestImageConfigVariant3!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                ChatRequestImageConfigVariant1,
                typeof(string),
                ChatRequestImageConfigVariant2,
                typeof(double),
                ChatRequestImageConfigVariant3,
                typeof(global::System.Collections.Generic.IList<object>),
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
        public bool Equals(ChatRequestImageConfig other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<string?>.Default.Equals(ChatRequestImageConfigVariant1, other.ChatRequestImageConfigVariant1) &&
                global::System.Collections.Generic.EqualityComparer<double?>.Default.Equals(ChatRequestImageConfigVariant2, other.ChatRequestImageConfigVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<object>?>.Default.Equals(ChatRequestImageConfigVariant3, other.ChatRequestImageConfigVariant3) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ChatRequestImageConfig obj1, ChatRequestImageConfig obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChatRequestImageConfig>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ChatRequestImageConfig obj1, ChatRequestImageConfig obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChatRequestImageConfig o && Equals(o);
        }
    }
}
