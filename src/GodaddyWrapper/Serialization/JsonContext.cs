﻿using GodaddyWrapper.Requests;
using GodaddyWrapper.Responses;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace GodaddyWrapper.Serialization
{
#if NETSTANDARD

    [JsonSourceGenerationOptions(GenerationMode = JsonSourceGenerationMode.Metadata,
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
        NumberHandling = JsonNumberHandling.AllowReadingFromString,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull)]
    //Requests
    [JsonSerializable(typeof(AbuseTicketCreate))]
    [JsonSerializable(typeof(AbuseTicketRetrieve))]
    [JsonSerializable(typeof(AbuseTicketDetailRetrieve))]
    [JsonSerializable(typeof(List<AftermarketListingExpiryCreate>))]
    [JsonSerializable(typeof(AgreementRetrieve))]
    [JsonSerializable(typeof(CertificateCancel))]
    [JsonSerializable(typeof(CertificateDomainControlCheck))]
    [JsonSerializable(typeof(CertificatesCreate))]
    [JsonSerializable(typeof(CertificateDownload))]
    [JsonSerializable(typeof(CertificateReissue))]
    [JsonSerializable(typeof(CertificateRenew))]
    [JsonSerializable(typeof(CertificateActionRetrieve))]
    [JsonSerializable(typeof(CertificateCallbackActionRegister))]
    [JsonSerializable(typeof(CertificateDetailRetrieve))]
    [JsonSerializable(typeof(CertificateSiteSealRetrieve))]
    [JsonSerializable(typeof(CertificateRevoke))]
    [JsonSerializable(typeof(CertificateCallbackUnregister))]
    [JsonSerializable(typeof(CountriesRetrieve))]
    [JsonSerializable(typeof(CountryDetailRetrieve))]
    [JsonSerializable(typeof(List<DNSRecord>))]
    [JsonSerializable(typeof(DomainAvailableBulk))]
    [JsonSerializable(typeof(DomainDelete))]
    [JsonSerializable(typeof(PrivacyDelete))]
    [JsonSerializable(typeof(DomainAvailable))]
    [JsonSerializable(typeof(DomainPurchase))]
    [JsonSerializable(typeof(DomainPurchaseWithoutPrivacy))]
    [JsonSerializable(typeof(PrivacyPurchase))]
    [JsonSerializable(typeof(DomainPurchaseSchema))]
    [JsonSerializable(typeof(DomainRenew))]
    [JsonSerializable(typeof(List<DNSRecordCreateType>))]
    [JsonSerializable(typeof(List<DNSRecordCreateTypeName>))]
    [JsonSerializable(typeof(DomainAgreements))]
    [JsonSerializable(typeof(DomainRetrieve))]
    [JsonSerializable(typeof(DNSRecordRetrieve))]
    [JsonSerializable(typeof(DomainSuggest))]
    [JsonSerializable(typeof(DomainTransferIn))]
    [JsonSerializable(typeof(DomainUpdate))]
    [JsonSerializable(typeof(DomainContacts))]
    [JsonSerializable(typeof(VerifyRegistrantEmail))]
    [JsonSerializable(typeof(OrderRetrieve))]
    [JsonSerializable(typeof(OrderDetailRetrieve))]
    [JsonSerializable(typeof(SubaccountCreate))]
    [JsonSerializable(typeof(ShopperRetrieve))]
    [JsonSerializable(typeof(ShopperUpdate))]
    [JsonSerializable(typeof(SubscriptionDelete))]
    [JsonSerializable(typeof(SubscriptionRetrieve))]
    [JsonSerializable(typeof(SubscriptionDetailRetrieve))]
    [JsonSerializable(typeof(Address))]
    [JsonSerializable(typeof(AftermarketListingExpiryCreate))]
    [JsonSerializable(typeof(AuctionListingRemove))]
    [JsonSerializable(typeof(CertificateAddress))]
    [JsonSerializable(typeof(CertificateCallbackRetrieve))]
    [JsonSerializable(typeof(CertificateContact))]
    [JsonSerializable(typeof(CertificateOrganizationCreate))]
    [JsonSerializable(typeof(Consent))]
    [JsonSerializable(typeof(Contact))]
    [JsonSerializable(typeof(DNSRecord))]
    [JsonSerializable(typeof(DNSRecordCreateType))]
    [JsonSerializable(typeof(DNSRecordCreateTypeName))]
    [JsonSerializable(typeof(DomainDetailRetrieve))]
    [JsonSerializable(typeof(EmailPreferenceRetrieve))]
    [JsonSerializable(typeof(TamperSignature))]
    //Responses
    [JsonSerializable(typeof(AbuseTicketIdResponse))]
    [JsonSerializable(typeof(AbuseTicketListResponse))]
    [JsonSerializable(typeof(AbuseTicketResponse))]
    [JsonSerializable(typeof(AftermarketListingActionResponse))]
    [JsonSerializable(typeof(ListingActionResponse))]
    [JsonSerializable(typeof(List<LegalAgreementResponse>))]
    [JsonSerializable(typeof(CertificateIdentifierResponse))]
    [JsonSerializable(typeof(CertificateBundleResponse))]
    [JsonSerializable(typeof(List<CertificateActionResponse>))]
    [JsonSerializable(typeof(CertificateSiteSealResponse))]
    [JsonSerializable(typeof(CountrySummaryResponse))]
    [JsonSerializable(typeof(CountryResponse))]
    [JsonSerializable(typeof(DomainAvailableBulkResultResponse))]
    [JsonSerializable(typeof(DomainAvailableResponse))]
    [JsonSerializable(typeof(DomainPurchaseResponse))]
    [JsonSerializable(typeof(JsonPropertyResponse))]
    [JsonSerializable(typeof(List<DomainRetrieveResponse>))]
    [JsonSerializable(typeof(DomainDetailResponse))]
    [JsonSerializable(typeof(List<DNSRecordResponse>))]
    [JsonSerializable(typeof(List<DomainSuggestionResponse>))]
    [JsonSerializable(typeof(List<TldSummaryResponse>))]
    [JsonSerializable(typeof(OrderListResponse))]
    [JsonSerializable(typeof(OrderResponse))]
    [JsonSerializable(typeof(ShopperIdResponse))]
    [JsonSerializable(typeof(ShopperResponse))]
    [JsonSerializable(typeof(SubscriptionListResponse))]
    [JsonSerializable(typeof(List<ProductGroupResponse>))]
    [JsonSerializable(typeof(SubscriptionResponse))]
    [JsonSerializable(typeof(AddressUsageDetailResponse))]
    [JsonSerializable(typeof(BillToResponse))]
    [JsonSerializable(typeof(CertificateActionResponse))]
    [JsonSerializable(typeof(CertificateAddressResponse))]
    [JsonSerializable(typeof(CertificateCallbackResponse))]
    [JsonSerializable(typeof(CertificateContactResponse))]
    [JsonSerializable(typeof(CertificateOrganizationResponse))]
    [JsonSerializable(typeof(CertificateResponse))]
    [JsonSerializable(typeof(ContactResponse))]
    [JsonSerializable(typeof(DiscountDetailItemResponse))]
    [JsonSerializable(typeof(DiscountDetailResponse))]
    [JsonSerializable(typeof(DNSRecordResponse))]
    [JsonSerializable(typeof(DomainAvailableBulkMixedResponse))]
    [JsonSerializable(typeof(DomainAvailableBulkResponse))]
    [JsonSerializable(typeof(DomainAvailableErrorResponse))]
    [JsonSerializable(typeof(DomainRetrieveResponse))]
    [JsonSerializable(typeof(DomainSuggestionResponse))]
    [JsonSerializable(typeof(DomainSummaryResponse))]
    [JsonSerializable(typeof(EmailPreferenceResponse))]
    [JsonSerializable(typeof(ErrorFieldResponse))]
    [JsonSerializable(typeof(ErrorResponse))]
    [JsonSerializable(typeof(JsonDataTypeResponse))]
    [JsonSerializable(typeof(JsonSchemaResponse))]
    [JsonSerializable(typeof(JurisdictionOfIncorporationResponse))]
    [JsonSerializable(typeof(LegalAgreementResponse))]
    [JsonSerializable(typeof(LineItemPricingResponse))]
    [JsonSerializable(typeof(LineItemResponse))]
    [JsonSerializable(typeof(LineItemSummaryResponse))]
    [JsonSerializable(typeof(OrderFeeResponse))]
    [JsonSerializable(typeof(OrderPricingResponse))]
    [JsonSerializable(typeof(OrderSummaryPricingResponse))]
    [JsonSerializable(typeof(OrderSummaryResponse))]
    [JsonSerializable(typeof(PaginationResponse))]
    [JsonSerializable(typeof(PaymentResponse))]
    [JsonSerializable(typeof(PEMCertificatesResponse))]
    [JsonSerializable(typeof(ProductGroupResponse))]
    [JsonSerializable(typeof(RealNameValidationResponse))]
    [JsonSerializable(typeof(StateResponse))]
    [JsonSerializable(typeof(SubjectAlternativeNameDetailsResponse))]
    [JsonSerializable(typeof(SubscriptionAddonResponse))]
    [JsonSerializable(typeof(SubscriptionBillingResponse))]
    [JsonSerializable(typeof(SubscriptionProductResponse))]
    [JsonSerializable(typeof(SubscriptionRelationsResponse))]
    [JsonSerializable(typeof(TamperSignatureResponse))]
    [JsonSerializable(typeof(TldSummaryResponse))]
    [JsonSerializable(typeof(UsageDetailItemResponse))]
    [JsonSerializable(typeof(UsageSummaryResponse))]
    internal partial class JsonContext : JsonSerializerContext
    {
    }
#else
    internal partial class JsonContext 
    {
         public static class Default
         {
            public readonly static JsonSerializerOptions Options = new JsonSerializerOptions(JsonSerializerDefaults.Web)
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            };
         }
    }
#endif
}