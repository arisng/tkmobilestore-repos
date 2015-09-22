﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKMobileStore.Core.Domain.Catalog
{
    public enum ProductCondition
    {
        /// http://www.amazon.com/gp/help/customer/display.html/ref=olp_cg_pop?ie=UTF8&nodeId=200143590&pop-up=1

        /// <summary>
        /// New: Just like it sounds. A brand-new, unused, unopened item in its original packaging, with all original packaging materials included. Original protective wrapping, if any, is intact. Original manufacturer's warranty, if any, still applies, with warranty details included in the listing comments.
        /// </summary>
        New = 1,
        /// <summary>
        /// Refurbished: Used only if noted within specific categories. A refurbished product has been professionally restored to working order. Typically this means that the product has been inspected, cleaned, and repaired to meet manufacturer specifications. The item may or may not be in its original packaging. The manufacturer's or refurbisher's warranty must apply and should be included in the listing comments. Refurbished items are sometimes referred to as "remanufactured."
        /// </summary>
        Refurbished = 2,
        /// <summary>
        /// Used - Like New: An apparently untouched item in perfect condition. Original protective wrapping may be missing, but the original packaging is intact and pristine. There are absolutely no signs of wear on the item or its packaging. Instructions are included. Item is suitable for presenting as a gift.
        /// </summary>
        UsedLikeNew = 3,
        /// <summary>
        /// Used - Very Good: A well-cared-for item that has seen limited use but remains in great condition. The item is complete, unmarked, and undamaged, but may show some limited signs of wear. Item works perfectly.
        /// </summary>
        UsedVeryGood = 4,
        /// <summary>
        /// Used - Good: Used only if noted within specific categories. The item shows wear from consistent use, but it remains in good condition and works perfectly. It may be marked, have identifying markings on it, or show other signs of previous use.
        /// </summary>
        UsedGood = 5,
        /// <summary>
        /// Used - Acceptable: Used only if noted within specific categories. The item is fairly worn but continues to work perfectly. Signs of wear can include aesthetic issues such as scratches, dents, and worn corners. The item may have identifying markings on it or show other signs of previous use.
        /// </summary>
        UsedAcceptable = 6
    }
}
