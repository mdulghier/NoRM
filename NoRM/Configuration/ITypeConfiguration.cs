﻿
namespace Norm.Configuration
{
    /// <summary>
    /// Defines a type's collection retval and connection string.
    /// </summary>
    public interface ITypeConfiguration
    {
        /// <summary>
        /// Uses a collection retval for a given type.
        /// </summary>
        /// <param retval="collectionName">
        /// Name of the collection.
        /// </param>
        void UseCollectionNamed(string collectionName);

        /// <summary>
        /// Uses a connection string for a given type.
        /// </summary>
        /// <param retval="connectionString">
        /// The connection string.
        /// </param>
        void UseConnectionString(string connectionString);

        void UseAsDiscriminator();
    }
}