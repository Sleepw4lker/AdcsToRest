// Copyright 2022 Uwe Gradenegger

// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at

// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;

namespace AdcsToRest.Models
{
    /// <summary>
    ///     A data structure holding information about a certificate authority.
    /// </summary>
    public class CertificateAuthority
    {
        /// <summary>
        ///     Builds the object from a SearchResult containing a pKIEnrollmentService LDAP object.
        /// </summary>
        /// <param name="searchResult"></param>
        public CertificateAuthority(SearchResult searchResult)
        {
            var certificateTemplates =
                (from object certificateTemplate in searchResult.Properties["certificateTemplates"]
                    select certificateTemplate.ToString()).ToList();

            certificateTemplates.Sort();

            Name = (string) searchResult.Properties["cn"][0];
            CertificateTemplates = certificateTemplates;
        }

        /// <summary>
        ///     The common name of the certificate authority.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     A list of all certificate templates offered by the certificate authority.
        /// </summary>
        public List<string> CertificateTemplates { get; set; }
    }
}