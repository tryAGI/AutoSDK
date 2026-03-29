//HintName: G.Models.Entity.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// Structured entity data for company or person search results. Only returned for category=company or category=people searches.
    /// </summary>
    public readonly partial struct Entity : global::System.IEquatable<Entity>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.EntityDiscriminatorType? Type { get; }

        /// <summary>
        /// Structured entity data for a company.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.CompanyEntity? Company { get; init; }
#else
        public global::G.CompanyEntity? Company { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Company))]
#endif
        public bool IsCompany => Company != null;

        /// <summary>
        /// Structured entity data for a person.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.PersonEntity? Person { get; init; }
#else
        public global::G.PersonEntity? Person { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Person))]
#endif
        public bool IsPerson => Person != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Entity(global::G.CompanyEntity value) => new Entity((global::G.CompanyEntity?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.CompanyEntity?(Entity @this) => @this.Company;

        /// <summary>
        /// 
        /// </summary>
        public Entity(global::G.CompanyEntity? value)
        {
            Company = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Entity(global::G.PersonEntity value) => new Entity((global::G.PersonEntity?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.PersonEntity?(Entity @this) => @this.Person;

        /// <summary>
        /// 
        /// </summary>
        public Entity(global::G.PersonEntity? value)
        {
            Person = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Entity(
            global::G.EntityDiscriminatorType? type,
            global::G.CompanyEntity? company,
            global::G.PersonEntity? person
            )
        {
            Type = type;

            Company = company;
            Person = person;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Person as object ??
            Company as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Company?.ToString() ??
            Person?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCompany && !IsPerson || !IsCompany && IsPerson;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.CompanyEntity?, TResult>? company = null,
            global::System.Func<global::G.PersonEntity?, TResult>? person = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompany && company != null)
            {
                return company(Company!);
            }
            else if (IsPerson && person != null)
            {
                return person(Person!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.CompanyEntity?>? company = null,
            global::System.Action<global::G.PersonEntity?>? person = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCompany)
            {
                company?.Invoke(Company!);
            }
            else if (IsPerson)
            {
                person?.Invoke(Person!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Company,
                typeof(global::G.CompanyEntity),
                Person,
                typeof(global::G.PersonEntity),
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
        public bool Equals(Entity other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.CompanyEntity?>.Default.Equals(Company, other.Company) &&
                global::System.Collections.Generic.EqualityComparer<global::G.PersonEntity?>.Default.Equals(Person, other.Person) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Entity obj1, Entity obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Entity>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Entity obj1, Entity obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Entity o && Equals(o);
        }
    }
}
