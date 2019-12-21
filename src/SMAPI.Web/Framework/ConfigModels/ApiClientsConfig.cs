namespace StardewModdingAPI.Web.Framework.ConfigModels
{
    /// <summary>The config settings for the API clients.</summary>
    internal class ApiClientsConfig
    {
        /*********
        ** Accessors
        *********/
        /****
        ** Generic
        ****/
        /// <summary>The user agent for API clients, where {0} is the SMAPI version.</summary>
        public string UserAgent { get; set; }


        /****
        ** Amazon Web Services
        ****/
        /// <summary>The access key for AWS authentication.</summary>
        public string AmazonAccessKey { get; set; }

        /// <summary>The secret key for AWS authentication.</summary>
        public string AmazonSecretKey { get; set; }

        /// <summary>The AWS region endpoint (like 'us-east-1').</summary>
        public string AmazonRegion { get; set; }

        /// <summary>The AWS bucket in which to store temporary uploaded logs.</summary>
        public string AmazonTempBucket { get; set; }


        /****
        ** Chucklefish
        ****/
        /// <summary>The base URL for the Chucklefish mod site.</summary>
        public string ChucklefishBaseUrl { get; set; }

        /// <summary>The URL for a mod page on the Chucklefish mod site excluding the <see cref="GitHubBaseUrl"/>, where {0} is the mod ID.</summary>
        public string ChucklefishModPageUrlFormat { get; set; }


        /****
        ** CurseForge
        ****/
        /// <summary>The base URL for the CurseForge API.</summary>
        public string CurseForgeBaseUrl { get; set; }


        /****
        ** GitHub
        ****/
        /// <summary>The base URL for the GitHub API.</summary>
        public string GitHubBaseUrl { get; set; }

        /// <summary>The Accept header value expected by the GitHub API.</summary>
        public string GitHubAcceptHeader { get; set; }

        /// <summary>The username with which to authenticate to the GitHub API (if any).</summary>
        public string GitHubUsername { get; set; }

        /// <summary>The password with which to authenticate to the GitHub API (if any).</summary>
        public string GitHubPassword { get; set; }

        /****
        ** ModDrop
        ****/
        /// <summary>The base URL for the ModDrop API.</summary>
        public string ModDropApiUrl { get; set; }

        /// <summary>The URL for a ModDrop mod page for the user, where {0} is the mod ID.</summary>
        public string ModDropModPageUrl { get; set; }

        /****
        ** Nexus Mods
        ****/
        /// <summary>The base URL for the Nexus Mods API.</summary>
        public string NexusBaseUrl { get; set; }

        /// <summary>The URL for a Nexus mod page for the user, excluding the <see cref="NexusBaseUrl"/>, where {0} is the mod ID.</summary>
        public string NexusModUrlFormat { get; set; }

        /// <summary>The URL for a Nexus mod page to scrape for versions, excluding the <see cref="NexusBaseUrl"/>, where {0} is the mod ID.</summary>
        public string NexusModScrapeUrlFormat { get; set; }

        /// <summary>The Nexus API authentication key.</summary>
        public string NexusApiKey { get; set; }

        /****
        ** Pastebin
        ****/
        /// <summary>The base URL for the Pastebin API.</summary>
        public string PastebinBaseUrl { get; set; }

        /// <summary>The user key used to authenticate with the Pastebin API.</summary>
        public string PastebinUserKey { get; set; }

        /// <summary>The developer key used to authenticate with the Pastebin API.</summary>
        public string PastebinDevKey { get; set; }

        /// <summary>Whether to enable uploading new files to Pastebin. This doesn't affect fetching already-uploaded files.</summary>
        public bool PastebinEnableUploads { get; set; }

    }
}
