namespace TraversalCoreProject.Areas.Admin.Models
{
    public class HotelSearchViewModel
    {
        public string __typename { get; set; }
        public Filtermetadata filterMetadata { get; set; }
        public Universalsortandfilter universalSortAndFilter { get; set; }
        public Property1[] properties { get; set; }
        public Propertysearchlisting[] propertySearchListings { get; set; }
        public Summary summary { get; set; }
        public Searchcriteria searchCriteria { get; set; }
        public Shoppingcontext shoppingContext { get; set; }
        public Map map { get; set; }
        public Clickstream clickstream { get; set; }


        public class Filtermetadata
        {
            public string __typename { get; set; }
            public Amenity[] amenities { get; set; }
            public Neighborhood[] neighborhoods { get; set; }
            public Pricerange priceRange { get; set; }
        }

        public class Pricerange
        {
            public string __typename { get; set; }
            public float max { get; set; }
            public float min { get; set; }
        }

        public class Amenity
        {
            public string __typename { get; set; }
            public int id { get; set; }
        }

        public class Neighborhood
        {
            public string __typename { get; set; }
            public string name { get; set; }
            public string regionId { get; set; }
        }

        public class Universalsortandfilter
        {
            public string __typename { get; set; }
            public Toolbar toolbar { get; set; }
            public Revealaction revealAction { get; set; }
            public Applyaction applyAction { get; set; }
            public Filtersection[] filterSections { get; set; }
            public Sortsection[] sortSections { get; set; }
        }

        public class Toolbar
        {
            public string __typename { get; set; }
            public string primary { get; set; }
            public Actions actions { get; set; }
        }

        public class Actions
        {
            public string __typename { get; set; }
            public Primary primary { get; set; }
            public Secondary[] secondaries { get; set; }
        }

        public class Primary
        {
            public string __typename { get; set; }
            public object primary { get; set; }
            public Action action { get; set; }
        }

        public class Action
        {
            public string __typename { get; set; }
            public string actionType { get; set; }
            public object accessibility { get; set; }
            public Analytics analytics { get; set; }
        }

        public class Analytics
        {
            public string __typename { get; set; }
            public string linkName { get; set; }
            public string referrerId { get; set; }
        }

        public class Secondary
        {
            public string __typename { get; set; }
            public string primary { get; set; }
            public bool disabled { get; set; }
            public Action1 action { get; set; }
        }

        public class Action1
        {
            public string __typename { get; set; }
            public string actionType { get; set; }
            public string accessibility { get; set; }
            public Analytics1 analytics { get; set; }
        }

        public class Analytics1
        {
            public string __typename { get; set; }
            public string linkName { get; set; }
            public string referrerId { get; set; }
        }

        public class Revealaction
        {
            public string __typename { get; set; }
            public string primary { get; set; }
            public Action2 action { get; set; }
            public string accessibility { get; set; }
            public int badge { get; set; }
            public bool disabled { get; set; }
            public Icon icon { get; set; }
        }

        public class Action2
        {
            public string __typename { get; set; }
            public string actionType { get; set; }
            public object accessibility { get; set; }
            public Analytics2 analytics { get; set; }
        }

        public class Analytics2
        {
            public string __typename { get; set; }
            public string linkName { get; set; }
            public string referrerId { get; set; }
        }

        public class Icon
        {
            public string __typename { get; set; }
            public string id { get; set; }
            public string description { get; set; }
            public object size { get; set; }
            public string token { get; set; }
            public object theme { get; set; }
        }

        public class Applyaction
        {
            public string __typename { get; set; }
            public string primary { get; set; }
            public Action3 action { get; set; }
            public string accessibility { get; set; }
            public object badge { get; set; }
            public bool disabled { get; set; }
            public object icon { get; set; }
        }

        public class Action3
        {
            public string __typename { get; set; }
            public string actionType { get; set; }
            public object accessibility { get; set; }
            public Analytics3 analytics { get; set; }
        }

        public class Analytics3
        {
            public string __typename { get; set; }
            public string linkName { get; set; }
            public string referrerId { get; set; }
        }

        public class Filtersection
        {
            public string __typename { get; set; }
            public string title { get; set; }
            public Field[] fields { get; set; }
        }

        public class Field
        {
            public string __typename { get; set; }
            public string primary { get; set; }
            public object secondary { get; set; }
            public Action4 action { get; set; }
            public string id { get; set; }
            public object label { get; set; }
            public string placeholder { get; set; }
            public object selected { get; set; }
            public Typeaheadinfo typeaheadInfo { get; set; }
            public Icon1 icon { get; set; }
            public Analytics5 analytics { get; set; }
            public Expando expando { get; set; }
            public Multiselectionoption[] multiSelectionOptions { get; set; }
            public Range range { get; set; }
            public Option[] options { get; set; }
            public Tilemultiselectionoption[] tileMultiSelectionOptions { get; set; }
        }

        public class Action4
        {
            public string __typename { get; set; }
            public string actionType { get; set; }
            public object accessibility { get; set; }
            public Analytics4 analytics { get; set; }
        }

        public class Analytics4
        {
            public string __typename { get; set; }
            public string linkName { get; set; }
            public string referrerId { get; set; }
        }

        public class Typeaheadinfo
        {
            public string __typename { get; set; }
            public string client { get; set; }
            public bool isDestination { get; set; }
            public string lineOfBusiness { get; set; }
            public int maxNumberOfResults { get; set; }
            public object packageType { get; set; }
            public bool personalize { get; set; }
            public int regionType { get; set; }
            public string typeaheadFeatures { get; set; }
        }

        public class Icon1
        {
            public string __typename { get; set; }
            public string id { get; set; }
            public string description { get; set; }
            public object size { get; set; }
            public string token { get; set; }
            public object theme { get; set; }
        }

        public class Analytics5
        {
            public string __typename { get; set; }
            public string linkName { get; set; }
            public string referrerId { get; set; }
        }

        public class Expando
        {
            public string __typename { get; set; }
            public int threshold { get; set; }
            public string collapseLabel { get; set; }
            public string expandLabel { get; set; }
            public Collapseanalytics collapseAnalytics { get; set; }
            public Expandanalytics expandAnalytics { get; set; }
        }

        public class Collapseanalytics
        {
            public string __typename { get; set; }
            public string linkName { get; set; }
            public string referrerId { get; set; }
        }

        public class Expandanalytics
        {
            public string __typename { get; set; }
            public string linkName { get; set; }
            public string referrerId { get; set; }
        }

        public class Range
        {
            public string __typename { get; set; }
            public string id { get; set; }
            public string primary { get; set; }
            public object secondary { get; set; }
            public object icon { get; set; }
            public Analytics6 analytics { get; set; }
            public Selected selected { get; set; }
            public Characteristics characteristics { get; set; }
        }

        public class Analytics6
        {
            public string __typename { get; set; }
            public string linkName { get; set; }
            public string referrerId { get; set; }
        }

        public class Selected
        {
            public string __typename { get; set; }
            public string id { get; set; }
            public int min { get; set; }
            public int max { get; set; }
        }

        public class Characteristics
        {
            public string __typename { get; set; }
            public int min { get; set; }
            public int max { get; set; }
            public int step { get; set; }
            public Label[] labels { get; set; }
        }

        public class Label
        {
            public string __typename { get; set; }
            public string label { get; set; }
            public int value { get; set; }
        }

        public class Multiselectionoption
        {
            public string __typename { get; set; }
            public string id { get; set; }
            public string primary { get; set; }
            public object secondary { get; set; }
            public Icon2 icon { get; set; }
            public Analytics7 analytics { get; set; }
            public string value { get; set; }
            public string description { get; set; }
            public bool selected { get; set; }
            public bool disabled { get; set; }
            public bool _default { get; set; }
            public Selectanalytics selectAnalytics { get; set; }
            public Deselectanalytics deselectAnalytics { get; set; }
        }

        public class Icon2
        {
            public string __typename { get; set; }
            public string id { get; set; }
            public string description { get; set; }
            public object size { get; set; }
            public string token { get; set; }
            public object theme { get; set; }
        }

        public class Analytics7
        {
            public string __typename { get; set; }
            public string linkName { get; set; }
            public string referrerId { get; set; }
        }

        public class Selectanalytics
        {
            public string __typename { get; set; }
            public string linkName { get; set; }
            public string referrerId { get; set; }
        }

        public class Deselectanalytics
        {
            public string __typename { get; set; }
            public string linkName { get; set; }
            public string referrerId { get; set; }
        }

        public class Option
        {
            public string __typename { get; set; }
            public string id { get; set; }
            public string primary { get; set; }
            public object secondary { get; set; }
            public Icon3 icon { get; set; }
            public Analytics8 analytics { get; set; }
            public string value { get; set; }
            public object description { get; set; }
            public bool selected { get; set; }
            public bool disabled { get; set; }
            public bool _default { get; set; }
            public Selectanalytics1 selectAnalytics { get; set; }
            public Deselectanalytics1 deselectAnalytics { get; set; }
        }

        public class Icon3
        {
            public string __typename { get; set; }
            public string id { get; set; }
            public string description { get; set; }
            public object size { get; set; }
            public string token { get; set; }
            public object theme { get; set; }
        }

        public class Analytics8
        {
            public string __typename { get; set; }
            public string linkName { get; set; }
            public string referrerId { get; set; }
        }

        public class Selectanalytics1
        {
            public string __typename { get; set; }
            public string linkName { get; set; }
            public string referrerId { get; set; }
        }

        public class Deselectanalytics1
        {
            public string __typename { get; set; }
            public string linkName { get; set; }
            public string referrerId { get; set; }
        }

        public class Tilemultiselectionoption
        {
            public string __typename { get; set; }
            public string id { get; set; }
            public string primary { get; set; }
            public object secondary { get; set; }
            public Icon4 icon { get; set; }
            public Analytics9 analytics { get; set; }
            public string value { get; set; }
            public object description { get; set; }
            public bool selected { get; set; }
            public bool disabled { get; set; }
            public bool _default { get; set; }
            public Selectanalytics2 selectAnalytics { get; set; }
            public Deselectanalytics2 deselectAnalytics { get; set; }
        }

        public class Icon4
        {
            public string __typename { get; set; }
            public string id { get; set; }
            public string description { get; set; }
            public object size { get; set; }
            public string token { get; set; }
            public object theme { get; set; }
        }

        public class Analytics9
        {
            public string __typename { get; set; }
            public string linkName { get; set; }
            public string referrerId { get; set; }
        }

        public class Selectanalytics2
        {
            public string __typename { get; set; }
            public string linkName { get; set; }
            public string referrerId { get; set; }
        }

        public class Deselectanalytics2
        {
            public string __typename { get; set; }
            public string linkName { get; set; }
            public string referrerId { get; set; }
        }

        public class Sortsection
        {
            public string __typename { get; set; }
            public object title { get; set; }
            public Field1[] fields { get; set; }
        }

        public class Field1
        {
            public string __typename { get; set; }
            public string primary { get; set; }
            public object secondary { get; set; }
            public Dropdownfilteroption[] dropdownFilterOptions { get; set; }
        }

        public class Dropdownfilteroption
        {
            public string __typename { get; set; }
            public string id { get; set; }
            public string primary { get; set; }
            public object secondary { get; set; }
            public object icon { get; set; }
            public Analytics10 analytics { get; set; }
            public string value { get; set; }
            public object description { get; set; }
            public bool selected { get; set; }
            public bool disabled { get; set; }
            public bool _default { get; set; }
            public Selectanalytics3 selectAnalytics { get; set; }
            public Deselectanalytics3 deselectAnalytics { get; set; }
        }

        public class Analytics10
        {
            public string __typename { get; set; }
            public string linkName { get; set; }
            public string referrerId { get; set; }
        }

        public class Selectanalytics3
        {
            public string __typename { get; set; }
            public string linkName { get; set; }
            public string referrerId { get; set; }
        }

        public class Deselectanalytics3
        {
            public string __typename { get; set; }
            public string linkName { get; set; }
            public string referrerId { get; set; }
        }

        public class Summary
        {
            public string __typename { get; set; }
            public int matchedPropertiesSize { get; set; }
            public Pricingscheme pricingScheme { get; set; }
            public object regionCompression { get; set; }
            public Loyaltyinfo loyaltyInfo { get; set; }
            public Resultstitlemodel resultsTitleModel { get; set; }
            public Resultssummary[] resultsSummary { get; set; }
        }

        public class Pricingscheme
        {
            public string __typename { get; set; }
            public string type { get; set; }
        }

        public class Loyaltyinfo
        {
            public string __typename { get; set; }
            public object saveWithPointsMessage { get; set; }
            public object saveWithPointsActionMessage { get; set; }
        }

        public class Resultstitlemodel
        {
            public string __typename { get; set; }
            public string header { get; set; }
        }

        public class Resultssummary
        {
            public string __typename { get; set; }
            public string accessibilityLabel { get; set; }
            public string value { get; set; }
            public Link link { get; set; }
        }

        public class Link
        {
            public string __typename { get; set; }
            public Clientsideanalytics clientSideAnalytics { get; set; }
            public Uri uri { get; set; }
        }

        public class Clientsideanalytics
        {
            public string __typename { get; set; }
            public string linkName { get; set; }
            public string referrerId { get; set; }
        }

        public class Uri
        {
            public string __typename { get; set; }
            public string value { get; set; }
        }

        public class Searchcriteria
        {
            public string __typename { get; set; }
            public object resolvedDateRange { get; set; }
        }

        public class Shoppingcontext
        {
            public string __typename { get; set; }
            public object multiItem { get; set; }
        }

        public class Map
        {
            public string __typename { get; set; }
            public object subtitle { get; set; }
        }

        public class Clickstream
        {
            public string __typename { get; set; }
            public object searchResultsViewed { get; set; }
        }

        public class Property1
        {
            public string __typename { get; set; }
            public string id { get; set; }
            public object[] featuredMessages { get; set; }
            public string name { get; set; }
            public Availability availability { get; set; }
            public Propertyimage propertyImage { get; set; }
            public Destinationinfo destinationInfo { get; set; }
            public object legalDisclaimer { get; set; }
            public object listingFooter { get; set; }
            public Mapmarker mapMarker { get; set; }
            public Neighborhood1 neighborhood { get; set; }
            public Offerbadge offerBadge { get; set; }
            public Offersummary offerSummary { get; set; }
            public object pinnedDetails { get; set; }
            public Price price { get; set; }
            public Priceafterloyaltypointsapplied priceAfterLoyaltyPointsApplied { get; set; }
            public Propertyfee[] propertyFees { get; set; }
            public Reviews reviews { get; set; }
            public int star { get; set; }
            public object supportingMessages { get; set; }
            public string regionId { get; set; }
            public Pricemetadata priceMetadata { get; set; }
            public object saveTripItem { get; set; }
        }

        public class Availability
        {
            public string __typename { get; set; }
            public bool available { get; set; }
            public int? minRoomsLeft { get; set; }
        }

        public class Propertyimage
        {
            public string __typename { get; set; }
            public string alt { get; set; }
            public object fallbackImage { get; set; }
            public Image image { get; set; }
            public int subjectId { get; set; }
        }

        public class Image
        {
            public string __typename { get; set; }
            public string description { get; set; }
            public string url { get; set; }
        }

        public class Destinationinfo
        {
            public string __typename { get; set; }
            public Distancefromdestination distanceFromDestination { get; set; }
            public string distanceFromMessaging { get; set; }
            public string regionId { get; set; }
        }

        public class Distancefromdestination
        {
            public string __typename { get; set; }
            public string unit { get; set; }
            public float value { get; set; }
        }

        public class Mapmarker
        {
            public string __typename { get; set; }
            public string label { get; set; }
            public Latlong latLong { get; set; }
        }

        public class Latlong
        {
            public string __typename { get; set; }
            public float latitude { get; set; }
            public float longitude { get; set; }
        }

        public class Neighborhood1
        {
            public string __typename { get; set; }
            public string name { get; set; }
        }

        public class Offerbadge
        {
            public string __typename { get; set; }
            public Primary1 primary { get; set; }
            public Secondary1 secondary { get; set; }
        }

        public class Primary1
        {
            public string __typename { get; set; }
            public string text { get; set; }
            public string theme_temp { get; set; }
            public Icon_Temp icon_temp { get; set; }
            public object mark { get; set; }
        }

        public class Icon_Temp
        {
            public string __typename { get; set; }
            public string id { get; set; }
            public string description { get; set; }
        }

        public class Secondary1
        {
            public string __typename { get; set; }
            public string text { get; set; }
            public string theme_temp { get; set; }
            public Icon_Temp1 icon_temp { get; set; }
            public object mark { get; set; }
        }

        public class Icon_Temp1
        {
            public string __typename { get; set; }
            public string id { get; set; }
            public string description { get; set; }
        }

        public class Offersummary
        {
            public string __typename { get; set; }
            public Message[] messages { get; set; }
            public Attribute[] attributes { get; set; }
        }

        public class Message
        {
            public string __typename { get; set; }
            public string message { get; set; }
            public string theme { get; set; }
            public string type { get; set; }
            public Mark mark { get; set; }
        }

        public class Mark
        {
            public string __typename { get; set; }
            public string id { get; set; }
            public string token { get; set; }
            public string description { get; set; }
        }

        public class Attribute
        {
            public string __typename { get; set; }
            public string type { get; set; }
        }

        public class Price
        {
            public string __typename { get; set; }
            public Option1[] options { get; set; }
            public object priceMessaging { get; set; }
            public Lead lead { get; set; }
            public Strikeout strikeOut { get; set; }
            public Displaymessage[] displayMessages { get; set; }
            public string strikeOutType { get; set; }
            public Pricemessage[] priceMessages { get; set; }
        }

        public class Lead
        {
            public string __typename { get; set; }
            public float amount { get; set; }
            public Currencyinfo currencyInfo { get; set; }
            public string formatted { get; set; }
        }

        public class Currencyinfo
        {
            public string __typename { get; set; }
            public string code { get; set; }
            public string symbol { get; set; }
        }

        public class Strikeout
        {
            public string __typename { get; set; }
            public float amount { get; set; }
            public Currencyinfo1 currencyInfo { get; set; }
            public string formatted { get; set; }
        }

        public class Currencyinfo1
        {
            public string __typename { get; set; }
            public string code { get; set; }
            public string symbol { get; set; }
        }

        public class Option1
        {
            public string __typename { get; set; }
            public Strikeout1 strikeOut { get; set; }
            public Disclaimer disclaimer { get; set; }
            public string formattedDisplayPrice { get; set; }
        }

        public class Strikeout1
        {
            public string __typename { get; set; }
            public float amount { get; set; }
            public string formatted { get; set; }
        }

        public class Disclaimer
        {
            public string __typename { get; set; }
            public string value { get; set; }
        }

        public class Displaymessage
        {
            public string __typename { get; set; }
            public Lineitem[] lineItems { get; set; }
        }

        public class Lineitem
        {
            public string __typename { get; set; }
            public Disclaimer1 disclaimer { get; set; }
            public Price1 price { get; set; }
            public string role { get; set; }
            public object accessibilityLabel { get; set; }
            public object mark { get; set; }
            public string state { get; set; }
            public string value { get; set; }
            public object badge { get; set; }
        }

        public class Disclaimer1
        {
            public string __typename { get; set; }
            public string[] content { get; set; }
            public object title { get; set; }
        }

        public class Price1
        {
            public string __typename { get; set; }
            public string formatted { get; set; }
            public string accessibilityLabel { get; set; }
        }

        public class Pricemessage
        {
            public string __typename { get; set; }
            public string value { get; set; }
        }

        public class Priceafterloyaltypointsapplied
        {
            public string __typename { get; set; }
            public Option2[] options { get; set; }
            public Lead1 lead { get; set; }
        }

        public class Lead1
        {
            public string __typename { get; set; }
            public float amount { get; set; }
            public Currencyinfo2 currencyInfo { get; set; }
            public string formatted { get; set; }
        }

        public class Currencyinfo2
        {
            public string __typename { get; set; }
            public string code { get; set; }
            public string symbol { get; set; }
        }

        public class Option2
        {
            public string __typename { get; set; }
            public Strikeout2 strikeOut { get; set; }
            public Disclaimer2 disclaimer { get; set; }
            public string formattedDisplayPrice { get; set; }
        }

        public class Strikeout2
        {
            public string __typename { get; set; }
            public float amount { get; set; }
            public string formatted { get; set; }
        }

        public class Disclaimer2
        {
            public string __typename { get; set; }
            public string value { get; set; }
        }

        public class Reviews
        {
            public string __typename { get; set; }
            public float score { get; set; }
            public int total { get; set; }
        }

        public class Pricemetadata
        {
            public string __typename { get; set; }
            public string discountType { get; set; }
            public Ratediscount rateDiscount { get; set; }
            public int? totalDiscountPercentage { get; set; }
        }

        public class Ratediscount
        {
            public string __typename { get; set; }
            public string description { get; set; }
        }

        public class Propertyfee
        {
            public string __typename { get; set; }
            public string type { get; set; }
        }

        public class Propertysearchlisting
        {
            public string __typename { get; set; }
            public string id { get; set; }
            public object[] featuredMessages { get; set; }
            public string name { get; set; }
            public Availability1 availability { get; set; }
            public Propertyimage1 propertyImage { get; set; }
            public Destinationinfo1 destinationInfo { get; set; }
            public object legalDisclaimer { get; set; }
            public object listingFooter { get; set; }
            public Mapmarker1 mapMarker { get; set; }
            public Neighborhood2 neighborhood { get; set; }
            public Offerbadge1 offerBadge { get; set; }
            public Offersummary1 offerSummary { get; set; }
            public object pinnedDetails { get; set; }
            public Price2 price { get; set; }
            public Priceafterloyaltypointsapplied1 priceAfterLoyaltyPointsApplied { get; set; }
            public Propertyfee1[] propertyFees { get; set; }
            public Reviews1 reviews { get; set; }
            public int star { get; set; }
            public object supportingMessages { get; set; }
            public string regionId { get; set; }
            public Pricemetadata1 priceMetadata { get; set; }
            public object saveTripItem { get; set; }
        }

        public class Availability1
        {
            public string __typename { get; set; }
            public bool available { get; set; }
            public int? minRoomsLeft { get; set; }
        }

        public class Propertyimage1
        {
            public string __typename { get; set; }
            public string alt { get; set; }
            public object fallbackImage { get; set; }
            public Image1 image { get; set; }
            public int subjectId { get; set; }
        }

        public class Image1
        {
            public string __typename { get; set; }
            public string description { get; set; }
            public string url { get; set; }
        }

        public class Destinationinfo1
        {
            public string __typename { get; set; }
            public Distancefromdestination1 distanceFromDestination { get; set; }
            public string distanceFromMessaging { get; set; }
            public string regionId { get; set; }
        }

        public class Distancefromdestination1
        {
            public string __typename { get; set; }
            public string unit { get; set; }
            public float value { get; set; }
        }

        public class Mapmarker1
        {
            public string __typename { get; set; }
            public string label { get; set; }
            public Latlong1 latLong { get; set; }
        }

        public class Latlong1
        {
            public string __typename { get; set; }
            public float latitude { get; set; }
            public float longitude { get; set; }
        }

        public class Neighborhood2
        {
            public string __typename { get; set; }
            public string name { get; set; }
        }

        public class Offerbadge1
        {
            public string __typename { get; set; }
            public Primary2 primary { get; set; }
            public Secondary2 secondary { get; set; }
        }

        public class Primary2
        {
            public string __typename { get; set; }
            public string text { get; set; }
            public string theme_temp { get; set; }
            public Icon_Temp2 icon_temp { get; set; }
            public object mark { get; set; }
        }

        public class Icon_Temp2
        {
            public string __typename { get; set; }
            public string id { get; set; }
            public string description { get; set; }
        }

        public class Secondary2
        {
            public string __typename { get; set; }
            public string text { get; set; }
            public string theme_temp { get; set; }
            public Icon_Temp3 icon_temp { get; set; }
            public object mark { get; set; }
        }

        public class Icon_Temp3
        {
            public string __typename { get; set; }
            public string id { get; set; }
            public string description { get; set; }
        }

        public class Offersummary1
        {
            public string __typename { get; set; }
            public Message1[] messages { get; set; }
            public Attribute1[] attributes { get; set; }
        }

        public class Message1
        {
            public string __typename { get; set; }
            public string message { get; set; }
            public string theme { get; set; }
            public string type { get; set; }
            public Mark1 mark { get; set; }
        }

        public class Mark1
        {
            public string __typename { get; set; }
            public string id { get; set; }
            public string token { get; set; }
            public string description { get; set; }
        }

        public class Attribute1
        {
            public string __typename { get; set; }
            public string type { get; set; }
        }

        public class Price2
        {
            public string __typename { get; set; }
            public Option3[] options { get; set; }
            public object priceMessaging { get; set; }
            public Lead2 lead { get; set; }
            public Strikeout3 strikeOut { get; set; }
            public Displaymessage1[] displayMessages { get; set; }
            public string strikeOutType { get; set; }
            public Pricemessage1[] priceMessages { get; set; }
        }

        public class Lead2
        {
            public string __typename { get; set; }
            public float amount { get; set; }
            public Currencyinfo3 currencyInfo { get; set; }
            public string formatted { get; set; }
        }

        public class Currencyinfo3
        {
            public string __typename { get; set; }
            public string code { get; set; }
            public string symbol { get; set; }
        }

        public class Strikeout3
        {
            public string __typename { get; set; }
            public float amount { get; set; }
            public Currencyinfo4 currencyInfo { get; set; }
            public string formatted { get; set; }
        }

        public class Currencyinfo4
        {
            public string __typename { get; set; }
            public string code { get; set; }
            public string symbol { get; set; }
        }

        public class Option3
        {
            public string __typename { get; set; }
            public Strikeout4 strikeOut { get; set; }
            public Disclaimer3 disclaimer { get; set; }
            public string formattedDisplayPrice { get; set; }
        }

        public class Strikeout4
        {
            public string __typename { get; set; }
            public float amount { get; set; }
            public string formatted { get; set; }
        }

        public class Disclaimer3
        {
            public string __typename { get; set; }
            public string value { get; set; }
        }

        public class Displaymessage1
        {
            public string __typename { get; set; }
            public Lineitem1[] lineItems { get; set; }
        }

        public class Lineitem1
        {
            public string __typename { get; set; }
            public Disclaimer4 disclaimer { get; set; }
            public Price3 price { get; set; }
            public string role { get; set; }
            public object accessibilityLabel { get; set; }
            public object mark { get; set; }
            public string state { get; set; }
            public string value { get; set; }
            public object badge { get; set; }
        }

        public class Disclaimer4
        {
            public string __typename { get; set; }
            public string[] content { get; set; }
            public object title { get; set; }
        }

        public class Price3
        {
            public string __typename { get; set; }
            public string formatted { get; set; }
            public string accessibilityLabel { get; set; }
        }

        public class Pricemessage1
        {
            public string __typename { get; set; }
            public string value { get; set; }
        }

        public class Priceafterloyaltypointsapplied1
        {
            public string __typename { get; set; }
            public Option4[] options { get; set; }
            public Lead3 lead { get; set; }
        }

        public class Lead3
        {
            public string __typename { get; set; }
            public float amount { get; set; }
            public Currencyinfo5 currencyInfo { get; set; }
            public string formatted { get; set; }
        }

        public class Currencyinfo5
        {
            public string __typename { get; set; }
            public string code { get; set; }
            public string symbol { get; set; }
        }

        public class Option4
        {
            public string __typename { get; set; }
            public Strikeout5 strikeOut { get; set; }
            public Disclaimer5 disclaimer { get; set; }
            public string formattedDisplayPrice { get; set; }
        }

        public class Strikeout5
        {
            public string __typename { get; set; }
            public float amount { get; set; }
            public string formatted { get; set; }
        }

        public class Disclaimer5
        {
            public string __typename { get; set; }
            public string value { get; set; }
        }

        public class Reviews1
        {
            public string __typename { get; set; }
            public float score { get; set; }
            public int total { get; set; }
        }

        public class Pricemetadata1
        {
            public string __typename { get; set; }
            public string discountType { get; set; }
            public Ratediscount1 rateDiscount { get; set; }
            public int? totalDiscountPercentage { get; set; }
        }

        public class Ratediscount1
        {
            public string __typename { get; set; }
            public string description { get; set; }
        }

        public class Propertyfee1
        {
            public string __typename { get; set; }
            public string type { get; set; }
        }

    }
}
