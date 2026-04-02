//HintName: G.Models.Key.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Represents a field key in search queries.<br/>
    /// Used for both selecting fields to return and building filter expressions.<br/>
    /// Predefined keys access special fields, while custom keys access metadata.<br/>
    /// # Predefined Keys<br/>
    /// - `Key::Document` - Document text content (`#document`)<br/>
    /// - `Key::Embedding` - Vector embeddings (`#embedding`)<br/>
    /// - `Key::Metadata` - All metadata fields (`#metadata`)<br/>
    /// - `Key::Score` - Search scores (`#score`)<br/>
    /// # Custom Keys<br/>
    /// Use `Key::field()` or `Key::from()` to reference metadata fields:<br/>
    /// ```<br/>
    /// use chroma_types::operator::Key;<br/>
    /// let key = Key::field("author");<br/>
    /// let key = Key::from("title");<br/>
    /// ```<br/>
    /// # Examples<br/>
    /// ## Building filters<br/>
    /// ```<br/>
    /// use chroma_types::operator::Key;<br/>
    /// // Equality<br/>
    /// let filter = Key::field("status").eq("published");<br/>
    /// // Comparisons<br/>
    /// let filter = Key::field("year").gte(2020);<br/>
    /// let filter = Key::field("score").lt(0.9);<br/>
    /// // Set operations<br/>
    /// let filter = Key::field("category").is_in(vec!["tech", "science"]);<br/>
    /// let filter = Key::field("status").not_in(vec!["deleted", "archived"]);<br/>
    /// // Document content<br/>
    /// let filter = Key::Document.contains("machine learning");<br/>
    /// let filter = Key::Document.regex(r"\bAPI\b");<br/>
    /// // Combining filters<br/>
    /// let filter = Key::field("status").eq("published")<br/>
    ///     &amp; Key::field("year").gte(2020);<br/>
    /// ```<br/>
    /// ## Selecting fields<br/>
    /// ```<br/>
    /// use chroma_types::plan::SearchPayload;<br/>
    /// use chroma_types::operator::Key;<br/>
    /// let search = SearchPayload::default()<br/>
    ///     .select([<br/>
    ///         Key::Document,<br/>
    ///         Key::Score,<br/>
    ///         Key::field("title"),<br/>
    ///         Key::field("author"),<br/>
    ///     ]);<br/>
    /// ```
    /// </summary>
    public readonly partial struct Key : global::System.IEquatable<Key>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.KeyVariant1? KeyVariant1 { get; init; }
#else
        public global::G.KeyVariant1? KeyVariant1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KeyVariant1))]
#endif
        public bool IsKeyVariant1 => KeyVariant1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.KeyVariant2? KeyVariant2 { get; init; }
#else
        public global::G.KeyVariant2? KeyVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KeyVariant2))]
#endif
        public bool IsKeyVariant2 => KeyVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.KeyVariant3? KeyVariant3 { get; init; }
#else
        public global::G.KeyVariant3? KeyVariant3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KeyVariant3))]
#endif
        public bool IsKeyVariant3 => KeyVariant3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.KeyVariant4? KeyVariant4 { get; init; }
#else
        public global::G.KeyVariant4? KeyVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KeyVariant4))]
#endif
        public bool IsKeyVariant4 => KeyVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.KeyVariant5? KeyVariant5 { get; init; }
#else
        public global::G.KeyVariant5? KeyVariant5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(KeyVariant5))]
#endif
        public bool IsKeyVariant5 => KeyVariant5 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Key(global::G.KeyVariant1 value) => new Key((global::G.KeyVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.KeyVariant1?(Key @this) => @this.KeyVariant1;

        /// <summary>
        /// 
        /// </summary>
        public Key(global::G.KeyVariant1? value)
        {
            KeyVariant1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Key(global::G.KeyVariant2 value) => new Key((global::G.KeyVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.KeyVariant2?(Key @this) => @this.KeyVariant2;

        /// <summary>
        /// 
        /// </summary>
        public Key(global::G.KeyVariant2? value)
        {
            KeyVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Key(global::G.KeyVariant3 value) => new Key((global::G.KeyVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.KeyVariant3?(Key @this) => @this.KeyVariant3;

        /// <summary>
        /// 
        /// </summary>
        public Key(global::G.KeyVariant3? value)
        {
            KeyVariant3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Key(global::G.KeyVariant4 value) => new Key((global::G.KeyVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.KeyVariant4?(Key @this) => @this.KeyVariant4;

        /// <summary>
        /// 
        /// </summary>
        public Key(global::G.KeyVariant4? value)
        {
            KeyVariant4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Key(global::G.KeyVariant5 value) => new Key((global::G.KeyVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.KeyVariant5?(Key @this) => @this.KeyVariant5;

        /// <summary>
        /// 
        /// </summary>
        public Key(global::G.KeyVariant5? value)
        {
            KeyVariant5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Key(
            global::G.KeyVariant1? keyVariant1,
            global::G.KeyVariant2? keyVariant2,
            global::G.KeyVariant3? keyVariant3,
            global::G.KeyVariant4? keyVariant4,
            global::G.KeyVariant5? keyVariant5
            )
        {
            KeyVariant1 = keyVariant1;
            KeyVariant2 = keyVariant2;
            KeyVariant3 = keyVariant3;
            KeyVariant4 = keyVariant4;
            KeyVariant5 = keyVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            KeyVariant5 as object ??
            KeyVariant4 as object ??
            KeyVariant3 as object ??
            KeyVariant2 as object ??
            KeyVariant1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            KeyVariant1?.ToValueString() ??
            KeyVariant2?.ToValueString() ??
            KeyVariant3?.ToValueString() ??
            KeyVariant4?.ToValueString() ??
            KeyVariant5?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsKeyVariant1 && !IsKeyVariant2 && !IsKeyVariant3 && !IsKeyVariant4 && !IsKeyVariant5 || !IsKeyVariant1 && IsKeyVariant2 && !IsKeyVariant3 && !IsKeyVariant4 && !IsKeyVariant5 || !IsKeyVariant1 && !IsKeyVariant2 && IsKeyVariant3 && !IsKeyVariant4 && !IsKeyVariant5 || !IsKeyVariant1 && !IsKeyVariant2 && !IsKeyVariant3 && IsKeyVariant4 && !IsKeyVariant5 || !IsKeyVariant1 && !IsKeyVariant2 && !IsKeyVariant3 && !IsKeyVariant4 && IsKeyVariant5;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.KeyVariant1?, TResult>? keyVariant1 = null,
            global::System.Func<global::G.KeyVariant2?, TResult>? keyVariant2 = null,
            global::System.Func<global::G.KeyVariant3?, TResult>? keyVariant3 = null,
            global::System.Func<global::G.KeyVariant4?, TResult>? keyVariant4 = null,
            global::System.Func<global::G.KeyVariant5?, TResult>? keyVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsKeyVariant1 && keyVariant1 != null)
            {
                return keyVariant1(KeyVariant1!);
            }
            else if (IsKeyVariant2 && keyVariant2 != null)
            {
                return keyVariant2(KeyVariant2!);
            }
            else if (IsKeyVariant3 && keyVariant3 != null)
            {
                return keyVariant3(KeyVariant3!);
            }
            else if (IsKeyVariant4 && keyVariant4 != null)
            {
                return keyVariant4(KeyVariant4!);
            }
            else if (IsKeyVariant5 && keyVariant5 != null)
            {
                return keyVariant5(KeyVariant5!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.KeyVariant1?>? keyVariant1 = null,
            global::System.Action<global::G.KeyVariant2?>? keyVariant2 = null,
            global::System.Action<global::G.KeyVariant3?>? keyVariant3 = null,
            global::System.Action<global::G.KeyVariant4?>? keyVariant4 = null,
            global::System.Action<global::G.KeyVariant5?>? keyVariant5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsKeyVariant1)
            {
                keyVariant1?.Invoke(KeyVariant1!);
            }
            else if (IsKeyVariant2)
            {
                keyVariant2?.Invoke(KeyVariant2!);
            }
            else if (IsKeyVariant3)
            {
                keyVariant3?.Invoke(KeyVariant3!);
            }
            else if (IsKeyVariant4)
            {
                keyVariant4?.Invoke(KeyVariant4!);
            }
            else if (IsKeyVariant5)
            {
                keyVariant5?.Invoke(KeyVariant5!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                KeyVariant1,
                typeof(global::G.KeyVariant1),
                KeyVariant2,
                typeof(global::G.KeyVariant2),
                KeyVariant3,
                typeof(global::G.KeyVariant3),
                KeyVariant4,
                typeof(global::G.KeyVariant4),
                KeyVariant5,
                typeof(global::G.KeyVariant5),
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
        public bool Equals(Key other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.KeyVariant1?>.Default.Equals(KeyVariant1, other.KeyVariant1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.KeyVariant2?>.Default.Equals(KeyVariant2, other.KeyVariant2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.KeyVariant3?>.Default.Equals(KeyVariant3, other.KeyVariant3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.KeyVariant4?>.Default.Equals(KeyVariant4, other.KeyVariant4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.KeyVariant5?>.Default.Equals(KeyVariant5, other.KeyVariant5) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Key obj1, Key obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Key>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Key obj1, Key obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Key o && Equals(o);
        }
    }
}
