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
        public global::G.KeyVariant1? Value1 { get; init; }
#else
        public global::G.KeyVariant1? Value1 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value1))]
#endif
        public bool IsValue1 => Value1 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.KeyVariant2? Value2 { get; init; }
#else
        public global::G.KeyVariant2? Value2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value2))]
#endif
        public bool IsValue2 => Value2 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.KeyVariant3? Value3 { get; init; }
#else
        public global::G.KeyVariant3? Value3 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value3))]
#endif
        public bool IsValue3 => Value3 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.KeyVariant4? Value4 { get; init; }
#else
        public global::G.KeyVariant4? Value4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value4))]
#endif
        public bool IsValue4 => Value4 != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.KeyVariant5? Value5 { get; init; }
#else
        public global::G.KeyVariant5? Value5 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Value5))]
#endif
        public bool IsValue5 => Value5 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Key(global::G.KeyVariant1 value) => new Key((global::G.KeyVariant1?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.KeyVariant1?(Key @this) => @this.Value1;

        /// <summary>
        /// 
        /// </summary>
        public Key(global::G.KeyVariant1? value)
        {
            Value1 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Key(global::G.KeyVariant2 value) => new Key((global::G.KeyVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.KeyVariant2?(Key @this) => @this.Value2;

        /// <summary>
        /// 
        /// </summary>
        public Key(global::G.KeyVariant2? value)
        {
            Value2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Key(global::G.KeyVariant3 value) => new Key((global::G.KeyVariant3?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.KeyVariant3?(Key @this) => @this.Value3;

        /// <summary>
        /// 
        /// </summary>
        public Key(global::G.KeyVariant3? value)
        {
            Value3 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Key(global::G.KeyVariant4 value) => new Key((global::G.KeyVariant4?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.KeyVariant4?(Key @this) => @this.Value4;

        /// <summary>
        /// 
        /// </summary>
        public Key(global::G.KeyVariant4? value)
        {
            Value4 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Key(global::G.KeyVariant5 value) => new Key((global::G.KeyVariant5?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.KeyVariant5?(Key @this) => @this.Value5;

        /// <summary>
        /// 
        /// </summary>
        public Key(global::G.KeyVariant5? value)
        {
            Value5 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Key(
            global::G.KeyVariant1? value1,
            global::G.KeyVariant2? value2,
            global::G.KeyVariant3? value3,
            global::G.KeyVariant4? value4,
            global::G.KeyVariant5? value5
            )
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
            Value5 = value5;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Value5 as object ??
            Value4 as object ??
            Value3 as object ??
            Value2 as object ??
            Value1 as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Value1?.ToValueString() ??
            Value2?.ToValueString() ??
            Value3?.ToValueString() ??
            Value4?.ToValueString() ??
            Value5?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 || !IsValue1 && IsValue2 && !IsValue3 && !IsValue4 && !IsValue5 || !IsValue1 && !IsValue2 && IsValue3 && !IsValue4 && !IsValue5 || !IsValue1 && !IsValue2 && !IsValue3 && IsValue4 && !IsValue5 || !IsValue1 && !IsValue2 && !IsValue3 && !IsValue4 && IsValue5;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.KeyVariant1?, TResult>? value1 = null,
            global::System.Func<global::G.KeyVariant2?, TResult>? value2 = null,
            global::System.Func<global::G.KeyVariant3?, TResult>? value3 = null,
            global::System.Func<global::G.KeyVariant4?, TResult>? value4 = null,
            global::System.Func<global::G.KeyVariant5?, TResult>? value5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1 && value1 != null)
            {
                return value1(Value1!);
            }
            else if (IsValue2 && value2 != null)
            {
                return value2(Value2!);
            }
            else if (IsValue3 && value3 != null)
            {
                return value3(Value3!);
            }
            else if (IsValue4 && value4 != null)
            {
                return value4(Value4!);
            }
            else if (IsValue5 && value5 != null)
            {
                return value5(Value5!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.KeyVariant1?>? value1 = null,
            global::System.Action<global::G.KeyVariant2?>? value2 = null,
            global::System.Action<global::G.KeyVariant3?>? value3 = null,
            global::System.Action<global::G.KeyVariant4?>? value4 = null,
            global::System.Action<global::G.KeyVariant5?>? value5 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsValue1)
            {
                value1?.Invoke(Value1!);
            }
            else if (IsValue2)
            {
                value2?.Invoke(Value2!);
            }
            else if (IsValue3)
            {
                value3?.Invoke(Value3!);
            }
            else if (IsValue4)
            {
                value4?.Invoke(Value4!);
            }
            else if (IsValue5)
            {
                value5?.Invoke(Value5!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Value1,
                typeof(global::G.KeyVariant1),
                Value2,
                typeof(global::G.KeyVariant2),
                Value3,
                typeof(global::G.KeyVariant3),
                Value4,
                typeof(global::G.KeyVariant4),
                Value5,
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
                global::System.Collections.Generic.EqualityComparer<global::G.KeyVariant1?>.Default.Equals(Value1, other.Value1) &&
                global::System.Collections.Generic.EqualityComparer<global::G.KeyVariant2?>.Default.Equals(Value2, other.Value2) &&
                global::System.Collections.Generic.EqualityComparer<global::G.KeyVariant3?>.Default.Equals(Value3, other.Value3) &&
                global::System.Collections.Generic.EqualityComparer<global::G.KeyVariant4?>.Default.Equals(Value4, other.Value4) &&
                global::System.Collections.Generic.EqualityComparer<global::G.KeyVariant5?>.Default.Equals(Value5, other.Value5) 
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
