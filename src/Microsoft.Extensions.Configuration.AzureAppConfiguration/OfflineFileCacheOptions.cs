﻿namespace Microsoft.Extensions.Configuration.AzureAppConfiguration
{
    /// <summary>
    /// Options for controlling the behavior of an <see cref="OfflineFileCache"/>.
    /// </summary>
    public class OfflineFileCacheOptions
    {
        /// <summary>
        /// The file path to use for persisting cached data.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// An opaque token representing the query for Azure App Configuration data used for comparison when storing and retrieving data.
        /// </summary>
        public string QueryToken { get; set; }
        
        /// <summary>
        /// Key used for encrypting data stored in the offline file cache.
        /// </summary>
        public byte[] Key { get; set; }

        /// <summary>
        /// Initilization vector used for encryptiong within the offline file cache.
        /// </summary>
        public byte[] IV { get; set; }

        /// <summary>
        /// Key used for signing data stored in the offline file cache.
        /// </summary>
        public byte[] SignKey { get; set; }
    }
}