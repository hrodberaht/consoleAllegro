﻿//------------------------------------------------------------------------------
// <generowane automatycznie>
//     Ten kod został wygenerowany przez narzędzie.
//     //
//     Zmiany w tym pliku mogą spowodować niewłaściwe zachowanie i zostaną utracone
//     w przypadku ponownego wygenerowania kodu.
// </generowane automatycznie>
//------------------------------------------------------------------------------

namespace Allegro
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="https://webapi.allegro.pl/service.php", ConfigurationName="Allegro.servicePort")]
    public interface servicePort
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="#doAddPackageInfoToPostBuyForm", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doAddPackageInfoToPostBuyFormResponse> doAddPackageInfoToPostBuyFormAsync(Allegro.doAddPackageInfoToPostBuyFormRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doAddToBlackList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doAddToBlackListResponse> doAddToBlackListAsync(Allegro.doAddToBlackListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doBidItem", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doBidItemResponse> doBidItemAsync(Allegro.doBidItemRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doCancelBidItem", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doCancelBidItemResponse> doCancelBidItemAsync(Allegro.doCancelBidItemRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doCancelRefundForm", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doCancelRefundFormResponse> doCancelRefundFormAsync(Allegro.doCancelRefundFormRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doCancelRefundWarning", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doCancelRefundWarningResponse> doCancelRefundWarningAsync(Allegro.doCancelRefundWarningRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doCancelTransaction", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doCancelTransactionResponse> doCancelTransactionAsync(Allegro.doCancelTransactionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doChangeItemFields", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doChangeItemFieldsResponse> doChangeItemFieldsAsync(Allegro.doChangeItemFieldsRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doChangePriceItem", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doChangePriceItemResponse> doChangePriceItemAsync(Allegro.doChangePriceItemRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doChangeQuantityItem", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doChangeQuantityItemResponse> doChangeQuantityItemAsync(Allegro.doChangeQuantityItemRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doCheckItemDescription", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doCheckItemDescriptionResponse> doCheckItemDescriptionAsync(Allegro.doCheckItemDescriptionRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doCheckNewAuctionExt", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doCheckNewAuctionExtResponse> doCheckNewAuctionExtAsync(Allegro.doCheckNewAuctionExtRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doFinishItem", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doFinishItemResponse> doFinishItemAsync(Allegro.doFinishItemRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doFinishItems", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doFinishItemsResponse> doFinishItemsAsync(Allegro.doFinishItemsRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doGetArchiveRefundsList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetArchiveRefundsListResponse> doGetArchiveRefundsListAsync(Allegro.doGetArchiveRefundsListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetBidItem2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetBidItem2Response> doGetBidItem2Async(Allegro.doGetBidItem2Request request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetBlackListUsers", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetBlackListUsersResponse> doGetBlackListUsersAsync(Allegro.doGetBlackListUsersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetCategoryPath", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetCategoryPathResponse> doGetCategoryPathAsync(Allegro.doGetCategoryPathRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doGetCatsData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetCatsDataResponse> doGetCatsDataAsync(Allegro.doGetCatsDataRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doGetCatsDataCount", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetCatsDataCountResponse> doGetCatsDataCountAsync(Allegro.doGetCatsDataCountRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doGetCatsDataLimit", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetCatsDataLimitResponse> doGetCatsDataLimitAsync(Allegro.doGetCatsDataLimitRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetCountries", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetCountriesResponse> doGetCountriesAsync(Allegro.doGetCountriesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetDeals", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetDealsResponse> doGetDealsAsync(Allegro.doGetDealsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetFilledPostBuyForms", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetFilledPostBuyFormsResponse> doGetFilledPostBuyFormsAsync(Allegro.doGetFilledPostBuyFormsRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doGetFreeDeliveryAmount", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetFreeDeliveryAmountResponse> doGetFreeDeliveryAmountAsync(Allegro.doGetFreeDeliveryAmountRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doGetItemFields", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetItemFieldsResponse> doGetItemFieldsAsync(Allegro.doGetItemFieldsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetItemsImages", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetItemsImagesResponse> doGetItemsImagesAsync(Allegro.doGetItemsImagesRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doGetItemsInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetItemsInfoResponse> doGetItemsInfoAsync(Allegro.doGetItemsInfoRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doGetItemsList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetItemsListResponse> doGetItemsListAsync(Allegro.doGetItemsListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetMessageToBuyer", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetMessageToBuyerResponse> doGetMessageToBuyerAsync(Allegro.doGetMessageToBuyerRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetMyAddresses", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetMyAddressesResponse> doGetMyAddressesAsync(Allegro.doGetMyAddressesRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doGetMyBidItems", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetMyBidItemsResponse> doGetMyBidItemsAsync(Allegro.doGetMyBidItemsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetMyCurrentShipmentPriceType", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetMyCurrentShipmentPriceTypeResponse> doGetMyCurrentShipmentPriceTypeAsync(Allegro.doGetMyCurrentShipmentPriceTypeRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doGetMyData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetMyDataResponse> doGetMyDataAsync(Allegro.doGetMyDataRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doGetMyFutureItems", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetMyFutureItemsResponse> doGetMyFutureItemsAsync(Allegro.doGetMyFutureItemsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetMyIncomingPayments", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetMyIncomingPaymentsResponse> doGetMyIncomingPaymentsAsync(Allegro.doGetMyIncomingPaymentsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetMyIncomingPaymentsRefunds", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetMyIncomingPaymentsRefundsResponse> doGetMyIncomingPaymentsRefundsAsync(Allegro.doGetMyIncomingPaymentsRefundsRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doGetMyNotSoldItems", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetMyNotSoldItemsResponse> doGetMyNotSoldItemsAsync(Allegro.doGetMyNotSoldItemsRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doGetMyNotWonItems", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetMyNotWonItemsResponse> doGetMyNotWonItemsAsync(Allegro.doGetMyNotWonItemsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetMyPayments", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetMyPaymentsResponse> doGetMyPaymentsAsync(Allegro.doGetMyPaymentsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetMyPaymentsInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetMyPaymentsInfoResponse> doGetMyPaymentsInfoAsync(Allegro.doGetMyPaymentsInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetMyPaymentsRefunds", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetMyPaymentsRefundsResponse> doGetMyPaymentsRefundsAsync(Allegro.doGetMyPaymentsRefundsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetMyPayouts", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetMyPayoutsResponse> doGetMyPayoutsAsync(Allegro.doGetMyPayoutsRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doGetMyPayoutsDetails", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetMyPayoutsDetailsResponse> doGetMyPayoutsDetailsAsync(Allegro.doGetMyPayoutsDetailsRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doGetMySellItems", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetMySellItemsResponse> doGetMySellItemsAsync(Allegro.doGetMySellItemsRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doGetMySoldItems", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetMySoldItemsResponse> doGetMySoldItemsAsync(Allegro.doGetMySoldItemsRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doGetMyWonItems", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetMyWonItemsResponse> doGetMyWonItemsAsync(Allegro.doGetMyWonItemsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetPaymentMethods", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetPaymentMethodsResponse> doGetPaymentMethodsAsync(Allegro.doGetPaymentMethodsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetPostBuyData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetPostBuyDataResponse> doGetPostBuyDataAsync(Allegro.doGetPostBuyDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetPostBuyFormsDataForBuyers", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetPostBuyFormsDataForBuyersResponse> doGetPostBuyFormsDataForBuyersAsync(Allegro.doGetPostBuyFormsDataForBuyersRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetPostBuyFormsDataForSellers", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetPostBuyFormsDataForSellersResponse> doGetPostBuyFormsDataForSellersAsync(Allegro.doGetPostBuyFormsDataForSellersRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doGetPostBuyFormsIds", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetPostBuyFormsIdsResponse> doGetPostBuyFormsIdsAsync(Allegro.doGetPostBuyFormsIdsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetPostBuyItemInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetPostBuyItemInfoResponse> doGetPostBuyItemInfoAsync(Allegro.doGetPostBuyItemInfoRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doGetRefundsDeals", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetRefundsDealsResponse> doGetRefundsDealsAsync(Allegro.doGetRefundsDealsRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doGetRefundsList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetRefundsListResponse> doGetRefundsListAsync(Allegro.doGetRefundsListRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doGetRefundsReasons", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetRefundsReasonsResponse> doGetRefundsReasonsAsync(Allegro.doGetRefundsReasonsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetRelatedItems", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetRelatedItemsResponse> doGetRelatedItemsAsync(Allegro.doGetRelatedItemsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetSellFormFieldsForCategory", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetSellFormFieldsForCategoryResponse> doGetSellFormFieldsForCategoryAsync(Allegro.doGetSellFormFieldsForCategoryRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doGetSessionHandleForWidget", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetSessionHandleForWidgetResponse> doGetSessionHandleForWidgetAsync(Allegro.doGetSessionHandleForWidgetRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doGetShipmentData", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetShipmentDataResponse> doGetShipmentDataAsync(Allegro.doGetShipmentDataRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetShipmentDataForRelatedItems", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetShipmentDataForRelatedItemsResponse> doGetShipmentDataForRelatedItemsAsync(Allegro.doGetShipmentDataForRelatedItemsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetShipmentPriceTypes", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetShipmentPriceTypesResponse> doGetShipmentPriceTypesAsync(Allegro.doGetShipmentPriceTypesRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doGetShopsTags", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetShopsTagsResponse> doGetShopsTagsAsync(Allegro.doGetShopsTagsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetSiteJournal", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetSiteJournalResponse> doGetSiteJournalAsync(Allegro.doGetSiteJournalRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetSiteJournalDeals", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetSiteJournalDealsResponse> doGetSiteJournalDealsAsync(Allegro.doGetSiteJournalDealsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetSiteJournalDealsInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetSiteJournalDealsInfoResponse> doGetSiteJournalDealsInfoAsync(Allegro.doGetSiteJournalDealsInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetSiteJournalInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetSiteJournalInfoResponse> doGetSiteJournalInfoAsync(Allegro.doGetSiteJournalInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetStatesInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetStatesInfoResponse> doGetStatesInfoAsync(Allegro.doGetStatesInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetSystemTime", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetSystemTimeResponse> doGetSystemTimeAsync(Allegro.doGetSystemTimeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetTransactionsIDs", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetTransactionsIDsResponse> doGetTransactionsIDsAsync(Allegro.doGetTransactionsIDsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetUserID", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetUserIDResponse> doGetUserIDAsync(Allegro.doGetUserIDRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doGetUserLogin", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doGetUserLoginResponse> doGetUserLoginAsync(Allegro.doGetUserLoginRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doLogin", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doLoginResponse> doLoginAsync(Allegro.doLoginRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doLoginEnc", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doLoginEncResponse> doLoginEncAsync(Allegro.doLoginEncRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doLoginWithAccessToken", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doLoginWithAccessTokenResponse> doLoginWithAccessTokenAsync(Allegro.doLoginWithAccessTokenRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doMyAccount2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doMyAccount2Response> doMyAccount2Async(Allegro.doMyAccount2Request request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doMyAccountItemsCount", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doMyAccountItemsCountResponse> doMyAccountItemsCountAsync(Allegro.doMyAccountItemsCountRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doMyBilling", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doMyBillingResponse> doMyBillingAsync(Allegro.doMyBillingRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doMyBillingItem", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doMyBillingItemResponse> doMyBillingItemAsync(Allegro.doMyBillingItemRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doMyContact", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doMyContactResponse> doMyContactAsync(Allegro.doMyContactRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doNewAuctionExt", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doNewAuctionExtResponse> doNewAuctionExtAsync(Allegro.doNewAuctionExtRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doQueryAllSysStatus", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doQueryAllSysStatusResponse> doQueryAllSysStatusAsync(Allegro.doQueryAllSysStatusRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doQuerySysStatus", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doQuerySysStatusResponse> doQuerySysStatusAsync(Allegro.doQuerySysStatusRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doRemoveFromBlackList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doRemoveFromBlackListResponse> doRemoveFromBlackListAsync(Allegro.doRemoveFromBlackListRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doRequestCancelBid", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doRequestCancelBidResponse> doRequestCancelBidAsync(Allegro.doRequestCancelBidRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doRequestPayout", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doRequestPayoutResponse> doRequestPayoutAsync(Allegro.doRequestPayoutRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doRequestSurcharge", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doRequestSurchargeResponse> doRequestSurchargeAsync(Allegro.doRequestSurchargeRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doSellSomeAgain", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doSellSomeAgainResponse> doSellSomeAgainAsync(Allegro.doSellSomeAgainRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doSellSomeAgainInShop", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doSellSomeAgainInShopResponse> doSellSomeAgainInShopAsync(Allegro.doSellSomeAgainInShopRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doSendEmailToUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doSendEmailToUserResponse> doSendEmailToUserAsync(Allegro.doSendEmailToUserRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doSendPostBuyForm", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doSendPostBuyFormResponse> doSendPostBuyFormAsync(Allegro.doSendPostBuyFormRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doSendRefundForm", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doSendRefundFormResponse> doSendRefundFormAsync(Allegro.doSendRefundFormRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doSetFreeDeliveryAmount", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doSetFreeDeliveryAmountResponse> doSetFreeDeliveryAmountAsync(Allegro.doSetFreeDeliveryAmountRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="#doSetShipmentPriceType", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doSetShipmentPriceTypeResponse> doSetShipmentPriceTypeAsync(Allegro.doSetShipmentPriceTypeRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doShowItemInfoExt", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doShowItemInfoExtResponse> doShowItemInfoExtAsync(Allegro.doShowItemInfoExtRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doShowUser", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doShowUserResponse> doShowUserAsync(Allegro.doShowUserRequest request);
        
        // CODEGEN: Trwa generowanie kontraktu komunikatu, ponieważ operacja ma wiele wartości zwracanych.
        [System.ServiceModel.OperationContractAttribute(Action="#doVerifyItem", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<Allegro.doVerifyItemResponse> doVerifyItemAsync(Allegro.doVerifyItemRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PackageInfoStruct
    {
        
        private int operatorIdField;
        
        private string packageIdField;
        
        /// <remarks/>
        public int operatorId
        {
            get
            {
                return this.operatorIdField;
            }
            set
            {
                this.operatorIdField = value;
            }
        }
        
        /// <remarks/>
        public string packageId
        {
            get
            {
                return this.packageIdField;
            }
            set
            {
                this.packageIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class SellRatingAverageStruct
    {
        
        private string sellRatingGroupTitleField;
        
        private float sellRatingGroupAverageField;
        
        /// <remarks/>
        public string sellRatingGroupTitle
        {
            get
            {
                return this.sellRatingGroupTitleField;
            }
            set
            {
                this.sellRatingGroupTitleField = value;
            }
        }
        
        /// <remarks/>
        public float sellRatingGroupAverage
        {
            get
            {
                return this.sellRatingGroupAverageField;
            }
            set
            {
                this.sellRatingGroupAverageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ShowUserFeedbacks
    {
        
        private int userFLastWeekField;
        
        private int userFLastMonthField;
        
        private int userFAllField;
        
        private int userFSoldItemsField;
        
        private int userFBuyItemsField;
        
        /// <remarks/>
        public int userFLastWeek
        {
            get
            {
                return this.userFLastWeekField;
            }
            set
            {
                this.userFLastWeekField = value;
            }
        }
        
        /// <remarks/>
        public int userFLastMonth
        {
            get
            {
                return this.userFLastMonthField;
            }
            set
            {
                this.userFLastMonthField = value;
            }
        }
        
        /// <remarks/>
        public int userFAll
        {
            get
            {
                return this.userFAllField;
            }
            set
            {
                this.userFAllField = value;
            }
        }
        
        /// <remarks/>
        public int userFSoldItems
        {
            get
            {
                return this.userFSoldItemsField;
            }
            set
            {
                this.userFSoldItemsField = value;
            }
        }
        
        /// <remarks/>
        public int userFBuyItems
        {
            get
            {
                return this.userFBuyItemsField;
            }
            set
            {
                this.userFBuyItemsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ItemInfoExt
    {
        
        private long itIdField;
        
        private int itCountryField;
        
        private string itNameField;
        
        private float itPriceField;
        
        private int itBidCountField;
        
        private long itEndingTimeField;
        
        private long itSellerIdField;
        
        private string itSellerLoginField;
        
        private int itSellerRatingField;
        
        private long itStartingTimeField;
        
        private float itStartingPriceField;
        
        private int itQuantityField;
        
        private int itFotoCountField;
        
        private float itReservePriceField;
        
        private string itLocationField;
        
        private float itBuyNowPriceField;
        
        private int itBuyNowActiveField;
        
        private float itAdvertisementPriceField;
        
        private bool itAdvertisementPriceFieldSpecified;
        
        private int itAdvertisementActiveField;
        
        private bool itAdvertisementActiveFieldSpecified;
        
        private int itHighBidderField;
        
        private string itHighBidderLoginField;
        
        private string itDescriptionField;
        
        private string itStandardizedDescriptionField;
        
        private int itOptionsField;
        
        private int itStateField;
        
        private float itWireTransferField;
        
        private float itPostDeliveryField;
        
        private string itPostInfoField;
        
        private int itQuantityTypeField;
        
        private int itIsEcoField;
        
        private long itHitCountField;
        
        private string itPostcodeField;
        
        private int itVatInvoiceField;
        
        private int itVatMarginInvoiceField;
        
        private int itWithoutVatInvoiceField;
        
        private string itBankAccount1Field;
        
        private string itBankAccount2Field;
        
        private int itStartingQuantityField;
        
        private int itIsForGuestsField;
        
        private int itHasProductField;
        
        private int itOrderFulfillmentTimeField;
        
        private int itEndingInfoField;
        
        private int itIsAllegroStandardField;
        
        private int itIsNewUsedField;
        
        private int itIsBrandZoneField;
        
        private bool itIsBrandZoneFieldSpecified;
        
        private int itIsFulfillmentTimeActiveField;
        
        private bool itIsFulfillmentTimeActiveFieldSpecified;
        
        private string itEanField;
        
        private string itContactField;
        
        /// <remarks/>
        public long itId
        {
            get
            {
                return this.itIdField;
            }
            set
            {
                this.itIdField = value;
            }
        }
        
        /// <remarks/>
        public int itCountry
        {
            get
            {
                return this.itCountryField;
            }
            set
            {
                this.itCountryField = value;
            }
        }
        
        /// <remarks/>
        public string itName
        {
            get
            {
                return this.itNameField;
            }
            set
            {
                this.itNameField = value;
            }
        }
        
        /// <remarks/>
        public float itPrice
        {
            get
            {
                return this.itPriceField;
            }
            set
            {
                this.itPriceField = value;
            }
        }
        
        /// <remarks/>
        public int itBidCount
        {
            get
            {
                return this.itBidCountField;
            }
            set
            {
                this.itBidCountField = value;
            }
        }
        
        /// <remarks/>
        public long itEndingTime
        {
            get
            {
                return this.itEndingTimeField;
            }
            set
            {
                this.itEndingTimeField = value;
            }
        }
        
        /// <remarks/>
        public long itSellerId
        {
            get
            {
                return this.itSellerIdField;
            }
            set
            {
                this.itSellerIdField = value;
            }
        }
        
        /// <remarks/>
        public string itSellerLogin
        {
            get
            {
                return this.itSellerLoginField;
            }
            set
            {
                this.itSellerLoginField = value;
            }
        }
        
        /// <remarks/>
        public int itSellerRating
        {
            get
            {
                return this.itSellerRatingField;
            }
            set
            {
                this.itSellerRatingField = value;
            }
        }
        
        /// <remarks/>
        public long itStartingTime
        {
            get
            {
                return this.itStartingTimeField;
            }
            set
            {
                this.itStartingTimeField = value;
            }
        }
        
        /// <remarks/>
        public float itStartingPrice
        {
            get
            {
                return this.itStartingPriceField;
            }
            set
            {
                this.itStartingPriceField = value;
            }
        }
        
        /// <remarks/>
        public int itQuantity
        {
            get
            {
                return this.itQuantityField;
            }
            set
            {
                this.itQuantityField = value;
            }
        }
        
        /// <remarks/>
        public int itFotoCount
        {
            get
            {
                return this.itFotoCountField;
            }
            set
            {
                this.itFotoCountField = value;
            }
        }
        
        /// <remarks/>
        public float itReservePrice
        {
            get
            {
                return this.itReservePriceField;
            }
            set
            {
                this.itReservePriceField = value;
            }
        }
        
        /// <remarks/>
        public string itLocation
        {
            get
            {
                return this.itLocationField;
            }
            set
            {
                this.itLocationField = value;
            }
        }
        
        /// <remarks/>
        public float itBuyNowPrice
        {
            get
            {
                return this.itBuyNowPriceField;
            }
            set
            {
                this.itBuyNowPriceField = value;
            }
        }
        
        /// <remarks/>
        public int itBuyNowActive
        {
            get
            {
                return this.itBuyNowActiveField;
            }
            set
            {
                this.itBuyNowActiveField = value;
            }
        }
        
        /// <remarks/>
        public float itAdvertisementPrice
        {
            get
            {
                return this.itAdvertisementPriceField;
            }
            set
            {
                this.itAdvertisementPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itAdvertisementPriceSpecified
        {
            get
            {
                return this.itAdvertisementPriceFieldSpecified;
            }
            set
            {
                this.itAdvertisementPriceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int itAdvertisementActive
        {
            get
            {
                return this.itAdvertisementActiveField;
            }
            set
            {
                this.itAdvertisementActiveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itAdvertisementActiveSpecified
        {
            get
            {
                return this.itAdvertisementActiveFieldSpecified;
            }
            set
            {
                this.itAdvertisementActiveFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int itHighBidder
        {
            get
            {
                return this.itHighBidderField;
            }
            set
            {
                this.itHighBidderField = value;
            }
        }
        
        /// <remarks/>
        public string itHighBidderLogin
        {
            get
            {
                return this.itHighBidderLoginField;
            }
            set
            {
                this.itHighBidderLoginField = value;
            }
        }
        
        /// <remarks/>
        public string itDescription
        {
            get
            {
                return this.itDescriptionField;
            }
            set
            {
                this.itDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string itStandardizedDescription
        {
            get
            {
                return this.itStandardizedDescriptionField;
            }
            set
            {
                this.itStandardizedDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public int itOptions
        {
            get
            {
                return this.itOptionsField;
            }
            set
            {
                this.itOptionsField = value;
            }
        }
        
        /// <remarks/>
        public int itState
        {
            get
            {
                return this.itStateField;
            }
            set
            {
                this.itStateField = value;
            }
        }
        
        /// <remarks/>
        public float itWireTransfer
        {
            get
            {
                return this.itWireTransferField;
            }
            set
            {
                this.itWireTransferField = value;
            }
        }
        
        /// <remarks/>
        public float itPostDelivery
        {
            get
            {
                return this.itPostDeliveryField;
            }
            set
            {
                this.itPostDeliveryField = value;
            }
        }
        
        /// <remarks/>
        public string itPostInfo
        {
            get
            {
                return this.itPostInfoField;
            }
            set
            {
                this.itPostInfoField = value;
            }
        }
        
        /// <remarks/>
        public int itQuantityType
        {
            get
            {
                return this.itQuantityTypeField;
            }
            set
            {
                this.itQuantityTypeField = value;
            }
        }
        
        /// <remarks/>
        public int itIsEco
        {
            get
            {
                return this.itIsEcoField;
            }
            set
            {
                this.itIsEcoField = value;
            }
        }
        
        /// <remarks/>
        public long itHitCount
        {
            get
            {
                return this.itHitCountField;
            }
            set
            {
                this.itHitCountField = value;
            }
        }
        
        /// <remarks/>
        public string itPostcode
        {
            get
            {
                return this.itPostcodeField;
            }
            set
            {
                this.itPostcodeField = value;
            }
        }
        
        /// <remarks/>
        public int itVatInvoice
        {
            get
            {
                return this.itVatInvoiceField;
            }
            set
            {
                this.itVatInvoiceField = value;
            }
        }
        
        /// <remarks/>
        public int itVatMarginInvoice
        {
            get
            {
                return this.itVatMarginInvoiceField;
            }
            set
            {
                this.itVatMarginInvoiceField = value;
            }
        }
        
        /// <remarks/>
        public int itWithoutVatInvoice
        {
            get
            {
                return this.itWithoutVatInvoiceField;
            }
            set
            {
                this.itWithoutVatInvoiceField = value;
            }
        }
        
        /// <remarks/>
        public string itBankAccount1
        {
            get
            {
                return this.itBankAccount1Field;
            }
            set
            {
                this.itBankAccount1Field = value;
            }
        }
        
        /// <remarks/>
        public string itBankAccount2
        {
            get
            {
                return this.itBankAccount2Field;
            }
            set
            {
                this.itBankAccount2Field = value;
            }
        }
        
        /// <remarks/>
        public int itStartingQuantity
        {
            get
            {
                return this.itStartingQuantityField;
            }
            set
            {
                this.itStartingQuantityField = value;
            }
        }
        
        /// <remarks/>
        public int itIsForGuests
        {
            get
            {
                return this.itIsForGuestsField;
            }
            set
            {
                this.itIsForGuestsField = value;
            }
        }
        
        /// <remarks/>
        public int itHasProduct
        {
            get
            {
                return this.itHasProductField;
            }
            set
            {
                this.itHasProductField = value;
            }
        }
        
        /// <remarks/>
        public int itOrderFulfillmentTime
        {
            get
            {
                return this.itOrderFulfillmentTimeField;
            }
            set
            {
                this.itOrderFulfillmentTimeField = value;
            }
        }
        
        /// <remarks/>
        public int itEndingInfo
        {
            get
            {
                return this.itEndingInfoField;
            }
            set
            {
                this.itEndingInfoField = value;
            }
        }
        
        /// <remarks/>
        public int itIsAllegroStandard
        {
            get
            {
                return this.itIsAllegroStandardField;
            }
            set
            {
                this.itIsAllegroStandardField = value;
            }
        }
        
        /// <remarks/>
        public int itIsNewUsed
        {
            get
            {
                return this.itIsNewUsedField;
            }
            set
            {
                this.itIsNewUsedField = value;
            }
        }
        
        /// <remarks/>
        public int itIsBrandZone
        {
            get
            {
                return this.itIsBrandZoneField;
            }
            set
            {
                this.itIsBrandZoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itIsBrandZoneSpecified
        {
            get
            {
                return this.itIsBrandZoneFieldSpecified;
            }
            set
            {
                this.itIsBrandZoneFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int itIsFulfillmentTimeActive
        {
            get
            {
                return this.itIsFulfillmentTimeActiveField;
            }
            set
            {
                this.itIsFulfillmentTimeActiveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itIsFulfillmentTimeActiveSpecified
        {
            get
            {
                return this.itIsFulfillmentTimeActiveFieldSpecified;
            }
            set
            {
                this.itIsFulfillmentTimeActiveFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string itEan
        {
            get
            {
                return this.itEanField;
            }
            set
            {
                this.itEanField = value;
            }
        }
        
        /// <remarks/>
        public string itContact
        {
            get
            {
                return this.itContactField;
            }
            set
            {
                this.itContactField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ActionDataStruct
    {
        
        private string actionKeyField;
        
        private string actionValueField;
        
        /// <remarks/>
        public string actionKey
        {
            get
            {
                return this.actionKeyField;
            }
            set
            {
                this.actionKeyField = value;
            }
        }
        
        /// <remarks/>
        public string actionValue
        {
            get
            {
                return this.actionValueField;
            }
            set
            {
                this.actionValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class TransactionPayByLinkStruct
    {
        
        private string actionHttpMethodField;
        
        private string actionUrlField;
        
        private ActionDataStruct[] actionDataField;
        
        /// <remarks/>
        public string actionHttpMethod
        {
            get
            {
                return this.actionHttpMethodField;
            }
            set
            {
                this.actionHttpMethodField = value;
            }
        }
        
        /// <remarks/>
        public string actionUrl
        {
            get
            {
                return this.actionUrlField;
            }
            set
            {
                this.actionUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public ActionDataStruct[] actionData
        {
            get
            {
                return this.actionDataField;
            }
            set
            {
                this.actionDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PostBuyFormStruct
    {
        
        private long transactionIdField;
        
        private long[] transactionPackageIdsField;
        
        private TransactionPayByLinkStruct transactionPayByLinkField;
        
        /// <remarks/>
        public long transactionId
        {
            get
            {
                return this.transactionIdField;
            }
            set
            {
                this.transactionIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] transactionPackageIds
        {
            get
            {
                return this.transactionPackageIdsField;
            }
            set
            {
                this.transactionPackageIdsField = value;
            }
        }
        
        /// <remarks/>
        public TransactionPayByLinkStruct transactionPayByLink
        {
            get
            {
                return this.transactionPayByLinkField;
            }
            set
            {
                this.transactionPayByLinkField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class InvoiceInfoStruct
    {
        
        private int invoiceAddressTypeField;
        
        private AddressUserDataStruct invoiceAddressDataField;
        
        private string invoiceNipField;
        
        /// <remarks/>
        public int invoiceAddressType
        {
            get
            {
                return this.invoiceAddressTypeField;
            }
            set
            {
                this.invoiceAddressTypeField = value;
            }
        }
        
        /// <remarks/>
        public AddressUserDataStruct invoiceAddressData
        {
            get
            {
                return this.invoiceAddressDataField;
            }
            set
            {
                this.invoiceAddressDataField = value;
            }
        }
        
        /// <remarks/>
        public string invoiceNip
        {
            get
            {
                return this.invoiceNipField;
            }
            set
            {
                this.invoiceNipField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class AddressUserDataStruct
    {
        
        private string userCompanyField;
        
        private string userFullNameField;
        
        private string userAddressField;
        
        private string userPostcodeField;
        
        private string userCityField;
        
        /// <remarks/>
        public string userCompany
        {
            get
            {
                return this.userCompanyField;
            }
            set
            {
                this.userCompanyField = value;
            }
        }
        
        /// <remarks/>
        public string userFullName
        {
            get
            {
                return this.userFullNameField;
            }
            set
            {
                this.userFullNameField = value;
            }
        }
        
        /// <remarks/>
        public string userAddress
        {
            get
            {
                return this.userAddressField;
            }
            set
            {
                this.userAddressField = value;
            }
        }
        
        /// <remarks/>
        public string userPostcode
        {
            get
            {
                return this.userPostcodeField;
            }
            set
            {
                this.userPostcodeField = value;
            }
        }
        
        /// <remarks/>
        public string userCity
        {
            get
            {
                return this.userCityField;
            }
            set
            {
                this.userCityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class NewPostBuyFormCommonStruct
    {
        
        private string paymentMethodIdField;
        
        private int shipmentAddressTypeField;
        
        private AddressUserDataStruct shipmentAddressDataField;
        
        private string contactPhoneField;
        
        private int invoiceOptionField;
        
        private InvoiceInfoStruct invoiceInfoField;
        
        /// <remarks/>
        public string paymentMethodId
        {
            get
            {
                return this.paymentMethodIdField;
            }
            set
            {
                this.paymentMethodIdField = value;
            }
        }
        
        /// <remarks/>
        public int shipmentAddressType
        {
            get
            {
                return this.shipmentAddressTypeField;
            }
            set
            {
                this.shipmentAddressTypeField = value;
            }
        }
        
        /// <remarks/>
        public AddressUserDataStruct shipmentAddressData
        {
            get
            {
                return this.shipmentAddressDataField;
            }
            set
            {
                this.shipmentAddressDataField = value;
            }
        }
        
        /// <remarks/>
        public string contactPhone
        {
            get
            {
                return this.contactPhoneField;
            }
            set
            {
                this.contactPhoneField = value;
            }
        }
        
        /// <remarks/>
        public int invoiceOption
        {
            get
            {
                return this.invoiceOptionField;
            }
            set
            {
                this.invoiceOptionField = value;
            }
        }
        
        /// <remarks/>
        public InvoiceInfoStruct invoiceInfo
        {
            get
            {
                return this.invoiceInfoField;
            }
            set
            {
                this.invoiceInfoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class NewPostBuyFormSellerStruct
    {
        
        private int sellerIdField;
        
        private long[] sellerItemIdsField;
        
        private int sellerShipmentIdField;
        
        private int sellerGdIdField;
        
        private bool sellerGdIdFieldSpecified;
        
        private float sellerShipmentAmountField;
        
        private bool sellerShipmentAmountFieldSpecified;
        
        private string sellerMessageToField;
        
        /// <remarks/>
        public int sellerId
        {
            get
            {
                return this.sellerIdField;
            }
            set
            {
                this.sellerIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] sellerItemIds
        {
            get
            {
                return this.sellerItemIdsField;
            }
            set
            {
                this.sellerItemIdsField = value;
            }
        }
        
        /// <remarks/>
        public int sellerShipmentId
        {
            get
            {
                return this.sellerShipmentIdField;
            }
            set
            {
                this.sellerShipmentIdField = value;
            }
        }
        
        /// <remarks/>
        public int sellerGdId
        {
            get
            {
                return this.sellerGdIdField;
            }
            set
            {
                this.sellerGdIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sellerGdIdSpecified
        {
            get
            {
                return this.sellerGdIdFieldSpecified;
            }
            set
            {
                this.sellerGdIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public float sellerShipmentAmount
        {
            get
            {
                return this.sellerShipmentAmountField;
            }
            set
            {
                this.sellerShipmentAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sellerShipmentAmountSpecified
        {
            get
            {
                return this.sellerShipmentAmountFieldSpecified;
            }
            set
            {
                this.sellerShipmentAmountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string sellerMessageTo
        {
            get
            {
                return this.sellerMessageToField;
            }
            set
            {
                this.sellerMessageToField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class StructSellFailed
    {
        
        private long sellItemIdField;
        
        private string sellFaultCodeField;
        
        private string sellFaultStringField;
        
        /// <remarks/>
        public long sellItemId
        {
            get
            {
                return this.sellItemIdField;
            }
            set
            {
                this.sellItemIdField = value;
            }
        }
        
        /// <remarks/>
        public string sellFaultCode
        {
            get
            {
                return this.sellFaultCodeField;
            }
            set
            {
                this.sellFaultCodeField = value;
            }
        }
        
        /// <remarks/>
        public string sellFaultString
        {
            get
            {
                return this.sellFaultStringField;
            }
            set
            {
                this.sellFaultStringField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class StructSellAgain
    {
        
        private long sellItemIdField;
        
        private string sellItemInfoField;
        
        private int sellItemLocalIdField;
        
        /// <remarks/>
        public long sellItemId
        {
            get
            {
                return this.sellItemIdField;
            }
            set
            {
                this.sellItemIdField = value;
            }
        }
        
        /// <remarks/>
        public string sellItemInfo
        {
            get
            {
                return this.sellItemInfoField;
            }
            set
            {
                this.sellItemInfoField = value;
            }
        }
        
        /// <remarks/>
        public int sellItemLocalId
        {
            get
            {
                return this.sellItemLocalIdField;
            }
            set
            {
                this.sellItemLocalIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class RequestPayoutStruct
    {
        
        private long payoutIdField;
        
        private float payoutAmountField;
        
        private long payoutTimeField;
        
        /// <remarks/>
        public long payoutId
        {
            get
            {
                return this.payoutIdField;
            }
            set
            {
                this.payoutIdField = value;
            }
        }
        
        /// <remarks/>
        public float payoutAmount
        {
            get
            {
                return this.payoutAmountField;
            }
            set
            {
                this.payoutAmountField = value;
            }
        }
        
        /// <remarks/>
        public long payoutTime
        {
            get
            {
                return this.payoutTimeField;
            }
            set
            {
                this.payoutTimeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class BlackListResStruct
    {
        
        private long userIdField;
        
        private int resultField;
        
        /// <remarks/>
        public long userId
        {
            get
            {
                return this.userIdField;
            }
            set
            {
                this.userIdField = value;
            }
        }
        
        /// <remarks/>
        public int result
        {
            get
            {
                return this.resultField;
            }
            set
            {
                this.resultField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class SysStatusType
    {
        
        private int countryIdField;
        
        private string programVersionField;
        
        private string catsVersionField;
        
        private string apiVersionField;
        
        private string attribVersionField;
        
        private string formSellVersionField;
        
        private string siteVersionField;
        
        private long verKeyField;
        
        /// <remarks/>
        public int countryId
        {
            get
            {
                return this.countryIdField;
            }
            set
            {
                this.countryIdField = value;
            }
        }
        
        /// <remarks/>
        public string programVersion
        {
            get
            {
                return this.programVersionField;
            }
            set
            {
                this.programVersionField = value;
            }
        }
        
        /// <remarks/>
        public string catsVersion
        {
            get
            {
                return this.catsVersionField;
            }
            set
            {
                this.catsVersionField = value;
            }
        }
        
        /// <remarks/>
        public string apiVersion
        {
            get
            {
                return this.apiVersionField;
            }
            set
            {
                this.apiVersionField = value;
            }
        }
        
        /// <remarks/>
        public string attribVersion
        {
            get
            {
                return this.attribVersionField;
            }
            set
            {
                this.attribVersionField = value;
            }
        }
        
        /// <remarks/>
        public string formSellVersion
        {
            get
            {
                return this.formSellVersionField;
            }
            set
            {
                this.formSellVersionField = value;
            }
        }
        
        /// <remarks/>
        public string siteVersion
        {
            get
            {
                return this.siteVersionField;
            }
            set
            {
                this.siteVersionField = value;
            }
        }
        
        /// <remarks/>
        public long verKey
        {
            get
            {
                return this.verKeyField;
            }
            set
            {
                this.verKeyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ItemTemplateCreateStruct
    {
        
        private int itemTemplateOptionField;
        
        private string itemTemplateNameField;
        
        /// <remarks/>
        public int itemTemplateOption
        {
            get
            {
                return this.itemTemplateOptionField;
            }
            set
            {
                this.itemTemplateOptionField = value;
            }
        }
        
        /// <remarks/>
        public string itemTemplateName
        {
            get
            {
                return this.itemTemplateNameField;
            }
            set
            {
                this.itemTemplateNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class MyContactList
    {
        
        private int contactUserIdField;
        
        private string contactNickField;
        
        private string contactFirstNameField;
        
        private string contactLastNameField;
        
        private string contactCompanyField;
        
        private string contactEmailField;
        
        private string contactStreetField;
        
        private string contactPostcodeField;
        
        private string contactCityField;
        
        private string contactCountryField;
        
        private string contactPhoneField;
        
        private string contactPhone2Field;
        
        private string contactRatingField;
        
        private string contactBlockedField;
        
        /// <remarks/>
        public int contactUserId
        {
            get
            {
                return this.contactUserIdField;
            }
            set
            {
                this.contactUserIdField = value;
            }
        }
        
        /// <remarks/>
        public string contactNick
        {
            get
            {
                return this.contactNickField;
            }
            set
            {
                this.contactNickField = value;
            }
        }
        
        /// <remarks/>
        public string contactFirstName
        {
            get
            {
                return this.contactFirstNameField;
            }
            set
            {
                this.contactFirstNameField = value;
            }
        }
        
        /// <remarks/>
        public string contactLastName
        {
            get
            {
                return this.contactLastNameField;
            }
            set
            {
                this.contactLastNameField = value;
            }
        }
        
        /// <remarks/>
        public string contactCompany
        {
            get
            {
                return this.contactCompanyField;
            }
            set
            {
                this.contactCompanyField = value;
            }
        }
        
        /// <remarks/>
        public string contactEmail
        {
            get
            {
                return this.contactEmailField;
            }
            set
            {
                this.contactEmailField = value;
            }
        }
        
        /// <remarks/>
        public string contactStreet
        {
            get
            {
                return this.contactStreetField;
            }
            set
            {
                this.contactStreetField = value;
            }
        }
        
        /// <remarks/>
        public string contactPostcode
        {
            get
            {
                return this.contactPostcodeField;
            }
            set
            {
                this.contactPostcodeField = value;
            }
        }
        
        /// <remarks/>
        public string contactCity
        {
            get
            {
                return this.contactCityField;
            }
            set
            {
                this.contactCityField = value;
            }
        }
        
        /// <remarks/>
        public string contactCountry
        {
            get
            {
                return this.contactCountryField;
            }
            set
            {
                this.contactCountryField = value;
            }
        }
        
        /// <remarks/>
        public string contactPhone
        {
            get
            {
                return this.contactPhoneField;
            }
            set
            {
                this.contactPhoneField = value;
            }
        }
        
        /// <remarks/>
        public string contactPhone2
        {
            get
            {
                return this.contactPhone2Field;
            }
            set
            {
                this.contactPhone2Field = value;
            }
        }
        
        /// <remarks/>
        public string contactRating
        {
            get
            {
                return this.contactRatingField;
            }
            set
            {
                this.contactRatingField = value;
            }
        }
        
        /// <remarks/>
        public string contactBlocked
        {
            get
            {
                return this.contactBlockedField;
            }
            set
            {
                this.contactBlockedField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ItemBilling
    {
        
        private string biNameField;
        
        private string biValueField;
        
        /// <remarks/>
        public string biName
        {
            get
            {
                return this.biNameField;
            }
            set
            {
                this.biNameField = value;
            }
        }
        
        /// <remarks/>
        public string biValue
        {
            get
            {
                return this.biValueField;
            }
            set
            {
                this.biValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class MyAccountStruct2
    {
        
        private string[] myAccountArrayField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public string[] myAccountArray
        {
            get
            {
                return this.myAccountArrayField;
            }
            set
            {
                this.myAccountArrayField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class StateInfoStruct
    {
        
        private int stateIdField;
        
        private string stateNameField;
        
        /// <remarks/>
        public int stateId
        {
            get
            {
                return this.stateIdField;
            }
            set
            {
                this.stateIdField = value;
            }
        }
        
        /// <remarks/>
        public string stateName
        {
            get
            {
                return this.stateNameField;
            }
            set
            {
                this.stateNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class SiteJournalInfo
    {
        
        private int itemsNumberField;
        
        private long lastItemDateField;
        
        /// <remarks/>
        public int itemsNumber
        {
            get
            {
                return this.itemsNumberField;
            }
            set
            {
                this.itemsNumberField = value;
            }
        }
        
        /// <remarks/>
        public long lastItemDate
        {
            get
            {
                return this.lastItemDateField;
            }
            set
            {
                this.lastItemDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class SiteJournalDealsInfoStruct
    {
        
        private int dealEventsCountField;
        
        private long dealLastEventTimeField;
        
        /// <remarks/>
        public int dealEventsCount
        {
            get
            {
                return this.dealEventsCountField;
            }
            set
            {
                this.dealEventsCountField = value;
            }
        }
        
        /// <remarks/>
        public long dealLastEventTime
        {
            get
            {
                return this.dealLastEventTimeField;
            }
            set
            {
                this.dealLastEventTimeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class SiteJournalDealsStruct
    {
        
        private long dealEventIdField;
        
        private int dealEventTypeField;
        
        private long dealEventTimeField;
        
        private long dealIdField;
        
        private long dealTransactionIdField;
        
        private int dealSellerIdField;
        
        private long dealItemIdField;
        
        private int dealBuyerIdField;
        
        private int dealQuantityField;
        
        /// <remarks/>
        public long dealEventId
        {
            get
            {
                return this.dealEventIdField;
            }
            set
            {
                this.dealEventIdField = value;
            }
        }
        
        /// <remarks/>
        public int dealEventType
        {
            get
            {
                return this.dealEventTypeField;
            }
            set
            {
                this.dealEventTypeField = value;
            }
        }
        
        /// <remarks/>
        public long dealEventTime
        {
            get
            {
                return this.dealEventTimeField;
            }
            set
            {
                this.dealEventTimeField = value;
            }
        }
        
        /// <remarks/>
        public long dealId
        {
            get
            {
                return this.dealIdField;
            }
            set
            {
                this.dealIdField = value;
            }
        }
        
        /// <remarks/>
        public long dealTransactionId
        {
            get
            {
                return this.dealTransactionIdField;
            }
            set
            {
                this.dealTransactionIdField = value;
            }
        }
        
        /// <remarks/>
        public int dealSellerId
        {
            get
            {
                return this.dealSellerIdField;
            }
            set
            {
                this.dealSellerIdField = value;
            }
        }
        
        /// <remarks/>
        public long dealItemId
        {
            get
            {
                return this.dealItemIdField;
            }
            set
            {
                this.dealItemIdField = value;
            }
        }
        
        /// <remarks/>
        public int dealBuyerId
        {
            get
            {
                return this.dealBuyerIdField;
            }
            set
            {
                this.dealBuyerIdField = value;
            }
        }
        
        /// <remarks/>
        public int dealQuantity
        {
            get
            {
                return this.dealQuantityField;
            }
            set
            {
                this.dealQuantityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class SiteJournal
    {
        
        private long rowIdField;
        
        private long itemIdField;
        
        private string changeTypeField;
        
        private long changeDateField;
        
        private float currentPriceField;
        
        private long itemSellerIdField;
        
        /// <remarks/>
        public long rowId
        {
            get
            {
                return this.rowIdField;
            }
            set
            {
                this.rowIdField = value;
            }
        }
        
        /// <remarks/>
        public long itemId
        {
            get
            {
                return this.itemIdField;
            }
            set
            {
                this.itemIdField = value;
            }
        }
        
        /// <remarks/>
        public string changeType
        {
            get
            {
                return this.changeTypeField;
            }
            set
            {
                this.changeTypeField = value;
            }
        }
        
        /// <remarks/>
        public long changeDate
        {
            get
            {
                return this.changeDateField;
            }
            set
            {
                this.changeDateField = value;
            }
        }
        
        /// <remarks/>
        public float currentPrice
        {
            get
            {
                return this.currentPriceField;
            }
            set
            {
                this.currentPriceField = value;
            }
        }
        
        /// <remarks/>
        public long itemSellerId
        {
            get
            {
                return this.itemSellerIdField;
            }
            set
            {
                this.itemSellerIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ShopsTagTypeStruct
    {
        
        private int idField;
        
        private string codeField;
        
        private string nameField;
        
        /// <remarks/>
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }
        
        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ShipmentPriceTypeStruct
    {
        
        private int shipmentPriceTypeIdField;
        
        private string shipmentPriceTypeNameField;
        
        /// <remarks/>
        public int shipmentPriceTypeId
        {
            get
            {
                return this.shipmentPriceTypeIdField;
            }
            set
            {
                this.shipmentPriceTypeIdField = value;
            }
        }
        
        /// <remarks/>
        public string shipmentPriceTypeName
        {
            get
            {
                return this.shipmentPriceTypeNameField;
            }
            set
            {
                this.shipmentPriceTypeNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ShipmentPaymentInfoStruct
    {
        
        private int shipmentIdField;
        
        private string shipmentNameField;
        
        private float shipmentAmountField;
        
        private int shipmentPaymentTypeField;
        
        private long[] shipmentItemIdsField;
        
        /// <remarks/>
        public int shipmentId
        {
            get
            {
                return this.shipmentIdField;
            }
            set
            {
                this.shipmentIdField = value;
            }
        }
        
        /// <remarks/>
        public string shipmentName
        {
            get
            {
                return this.shipmentNameField;
            }
            set
            {
                this.shipmentNameField = value;
            }
        }
        
        /// <remarks/>
        public float shipmentAmount
        {
            get
            {
                return this.shipmentAmountField;
            }
            set
            {
                this.shipmentAmountField = value;
            }
        }
        
        /// <remarks/>
        public int shipmentPaymentType
        {
            get
            {
                return this.shipmentPaymentTypeField;
            }
            set
            {
                this.shipmentPaymentTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] shipmentItemIds
        {
            get
            {
                return this.shipmentItemIdsField;
            }
            set
            {
                this.shipmentItemIdsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class SellerPaymentInfoStruct
    {
        
        private ShipmentPaymentInfoStruct[] shipmentPaymentInfoPzaField;
        
        private ShipmentPaymentInfoStruct[] shipmentPaymentInfoNonPzaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public ShipmentPaymentInfoStruct[] shipmentPaymentInfoPza
        {
            get
            {
                return this.shipmentPaymentInfoPzaField;
            }
            set
            {
                this.shipmentPaymentInfoPzaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public ShipmentPaymentInfoStruct[] shipmentPaymentInfoNonPza
        {
            get
            {
                return this.shipmentPaymentInfoNonPzaField;
            }
            set
            {
                this.shipmentPaymentInfoNonPzaField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class SellerShipmentDataStruct
    {
        
        private int sellerIdField;
        
        private SellerPaymentInfoStruct sellerPaymentInfoField;
        
        private int sellerOtherShipmentIsActiveField;
        
        private ShipmentPaymentInfoStruct[] generalDeliveryPaymentInfoField;
        
        /// <remarks/>
        public int sellerId
        {
            get
            {
                return this.sellerIdField;
            }
            set
            {
                this.sellerIdField = value;
            }
        }
        
        /// <remarks/>
        public SellerPaymentInfoStruct sellerPaymentInfo
        {
            get
            {
                return this.sellerPaymentInfoField;
            }
            set
            {
                this.sellerPaymentInfoField = value;
            }
        }
        
        /// <remarks/>
        public int sellerOtherShipmentIsActive
        {
            get
            {
                return this.sellerOtherShipmentIsActiveField;
            }
            set
            {
                this.sellerOtherShipmentIsActiveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public ShipmentPaymentInfoStruct[] generalDeliveryPaymentInfo
        {
            get
            {
                return this.generalDeliveryPaymentInfoField;
            }
            set
            {
                this.generalDeliveryPaymentInfoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class RelatedItemsShipmentDataStruct
    {
        
        private SellerShipmentDataStruct[] sellerShipmentDataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public SellerShipmentDataStruct[] sellerShipmentData
        {
            get
            {
                return this.sellerShipmentDataField;
            }
            set
            {
                this.sellerShipmentDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ShipmentTimeStruct
    {
        
        private int shipmentTimeFromField;
        
        private int shipmentTimeToField;
        
        /// <remarks/>
        public int shipmentTimeFrom
        {
            get
            {
                return this.shipmentTimeFromField;
            }
            set
            {
                this.shipmentTimeFromField = value;
            }
        }
        
        /// <remarks/>
        public int shipmentTimeTo
        {
            get
            {
                return this.shipmentTimeToField;
            }
            set
            {
                this.shipmentTimeToField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ShipmentDataStruct
    {
        
        private int shipmentIdField;
        
        private string shipmentNameField;
        
        private int shipmentTypeField;
        
        private ShipmentTimeStruct shipmentTimeField;
        
        /// <remarks/>
        public int shipmentId
        {
            get
            {
                return this.shipmentIdField;
            }
            set
            {
                this.shipmentIdField = value;
            }
        }
        
        /// <remarks/>
        public string shipmentName
        {
            get
            {
                return this.shipmentNameField;
            }
            set
            {
                this.shipmentNameField = value;
            }
        }
        
        /// <remarks/>
        public int shipmentType
        {
            get
            {
                return this.shipmentTypeField;
            }
            set
            {
                this.shipmentTypeField = value;
            }
        }
        
        /// <remarks/>
        public ShipmentTimeStruct shipmentTime
        {
            get
            {
                return this.shipmentTimeField;
            }
            set
            {
                this.shipmentTimeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class SellFormType
    {
        
        private int sellFormIdField;
        
        private string sellFormTitleField;
        
        private int sellFormCatField;
        
        private int sellFormTypeField;
        
        private int sellFormResTypeField;
        
        private int sellFormDefValueField;
        
        private int sellFormOptField;
        
        private int sellFormPosField;
        
        private int sellFormLengthField;
        
        private string sellMinValueField;
        
        private string sellMaxValueField;
        
        private string sellFormDescField;
        
        private string sellFormOptsValuesField;
        
        private string sellFormFieldDescField;
        
        private int sellFormParamIdField;
        
        private string sellFormParamValuesField;
        
        private int sellFormParentIdField;
        
        private string sellFormParentValueField;
        
        private string sellFormUnitField;
        
        private int sellFormOptionsField;
        
        /// <remarks/>
        public int sellFormId
        {
            get
            {
                return this.sellFormIdField;
            }
            set
            {
                this.sellFormIdField = value;
            }
        }
        
        /// <remarks/>
        public string sellFormTitle
        {
            get
            {
                return this.sellFormTitleField;
            }
            set
            {
                this.sellFormTitleField = value;
            }
        }
        
        /// <remarks/>
        public int sellFormCat
        {
            get
            {
                return this.sellFormCatField;
            }
            set
            {
                this.sellFormCatField = value;
            }
        }
        
        /// <remarks/>
        public int sellFormType
        {
            get
            {
                return this.sellFormTypeField;
            }
            set
            {
                this.sellFormTypeField = value;
            }
        }
        
        /// <remarks/>
        public int sellFormResType
        {
            get
            {
                return this.sellFormResTypeField;
            }
            set
            {
                this.sellFormResTypeField = value;
            }
        }
        
        /// <remarks/>
        public int sellFormDefValue
        {
            get
            {
                return this.sellFormDefValueField;
            }
            set
            {
                this.sellFormDefValueField = value;
            }
        }
        
        /// <remarks/>
        public int sellFormOpt
        {
            get
            {
                return this.sellFormOptField;
            }
            set
            {
                this.sellFormOptField = value;
            }
        }
        
        /// <remarks/>
        public int sellFormPos
        {
            get
            {
                return this.sellFormPosField;
            }
            set
            {
                this.sellFormPosField = value;
            }
        }
        
        /// <remarks/>
        public int sellFormLength
        {
            get
            {
                return this.sellFormLengthField;
            }
            set
            {
                this.sellFormLengthField = value;
            }
        }
        
        /// <remarks/>
        public string sellMinValue
        {
            get
            {
                return this.sellMinValueField;
            }
            set
            {
                this.sellMinValueField = value;
            }
        }
        
        /// <remarks/>
        public string sellMaxValue
        {
            get
            {
                return this.sellMaxValueField;
            }
            set
            {
                this.sellMaxValueField = value;
            }
        }
        
        /// <remarks/>
        public string sellFormDesc
        {
            get
            {
                return this.sellFormDescField;
            }
            set
            {
                this.sellFormDescField = value;
            }
        }
        
        /// <remarks/>
        public string sellFormOptsValues
        {
            get
            {
                return this.sellFormOptsValuesField;
            }
            set
            {
                this.sellFormOptsValuesField = value;
            }
        }
        
        /// <remarks/>
        public string sellFormFieldDesc
        {
            get
            {
                return this.sellFormFieldDescField;
            }
            set
            {
                this.sellFormFieldDescField = value;
            }
        }
        
        /// <remarks/>
        public int sellFormParamId
        {
            get
            {
                return this.sellFormParamIdField;
            }
            set
            {
                this.sellFormParamIdField = value;
            }
        }
        
        /// <remarks/>
        public string sellFormParamValues
        {
            get
            {
                return this.sellFormParamValuesField;
            }
            set
            {
                this.sellFormParamValuesField = value;
            }
        }
        
        /// <remarks/>
        public int sellFormParentId
        {
            get
            {
                return this.sellFormParentIdField;
            }
            set
            {
                this.sellFormParentIdField = value;
            }
        }
        
        /// <remarks/>
        public string sellFormParentValue
        {
            get
            {
                return this.sellFormParentValueField;
            }
            set
            {
                this.sellFormParentValueField = value;
            }
        }
        
        /// <remarks/>
        public string sellFormUnit
        {
            get
            {
                return this.sellFormUnitField;
            }
            set
            {
                this.sellFormUnitField = value;
            }
        }
        
        /// <remarks/>
        public int sellFormOptions
        {
            get
            {
                return this.sellFormOptionsField;
            }
            set
            {
                this.sellFormOptionsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class SellFormFieldsForCategoryStruct
    {
        
        private SellFormType[] sellFormFieldsListField;
        
        private long sellFormFieldsVersionKeyField;
        
        private string sellFormFieldsComponentValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public SellFormType[] sellFormFieldsList
        {
            get
            {
                return this.sellFormFieldsListField;
            }
            set
            {
                this.sellFormFieldsListField = value;
            }
        }
        
        /// <remarks/>
        public long sellFormFieldsVersionKey
        {
            get
            {
                return this.sellFormFieldsVersionKeyField;
            }
            set
            {
                this.sellFormFieldsVersionKeyField = value;
            }
        }
        
        /// <remarks/>
        public string sellFormFieldsComponentValue
        {
            get
            {
                return this.sellFormFieldsComponentValueField;
            }
            set
            {
                this.sellFormFieldsComponentValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class RelatedItemStruct
    {
        
        private long itemIdField;
        
        private string itemTitleField;
        
        private string itemThumbnailField;
        
        private float itemPriceField;
        
        private int itemBoughtCountField;
        
        private float itemAmountField;
        
        private int itemPaymentTypeField;
        
        private long itemSellerIdField;
        
        private string itemSellerNameField;
        
        private int itemInvoiceInfoField;
        
        private int itemCategoryIdField;
        
        private bool itemCategoryIdFieldSpecified;
        
        /// <remarks/>
        public long itemId
        {
            get
            {
                return this.itemIdField;
            }
            set
            {
                this.itemIdField = value;
            }
        }
        
        /// <remarks/>
        public string itemTitle
        {
            get
            {
                return this.itemTitleField;
            }
            set
            {
                this.itemTitleField = value;
            }
        }
        
        /// <remarks/>
        public string itemThumbnail
        {
            get
            {
                return this.itemThumbnailField;
            }
            set
            {
                this.itemThumbnailField = value;
            }
        }
        
        /// <remarks/>
        public float itemPrice
        {
            get
            {
                return this.itemPriceField;
            }
            set
            {
                this.itemPriceField = value;
            }
        }
        
        /// <remarks/>
        public int itemBoughtCount
        {
            get
            {
                return this.itemBoughtCountField;
            }
            set
            {
                this.itemBoughtCountField = value;
            }
        }
        
        /// <remarks/>
        public float itemAmount
        {
            get
            {
                return this.itemAmountField;
            }
            set
            {
                this.itemAmountField = value;
            }
        }
        
        /// <remarks/>
        public int itemPaymentType
        {
            get
            {
                return this.itemPaymentTypeField;
            }
            set
            {
                this.itemPaymentTypeField = value;
            }
        }
        
        /// <remarks/>
        public long itemSellerId
        {
            get
            {
                return this.itemSellerIdField;
            }
            set
            {
                this.itemSellerIdField = value;
            }
        }
        
        /// <remarks/>
        public string itemSellerName
        {
            get
            {
                return this.itemSellerNameField;
            }
            set
            {
                this.itemSellerNameField = value;
            }
        }
        
        /// <remarks/>
        public int itemInvoiceInfo
        {
            get
            {
                return this.itemInvoiceInfoField;
            }
            set
            {
                this.itemInvoiceInfoField = value;
            }
        }
        
        /// <remarks/>
        public int itemCategoryId
        {
            get
            {
                return this.itemCategoryIdField;
            }
            set
            {
                this.itemCategoryIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemCategoryIdSpecified
        {
            get
            {
                return this.itemCategoryIdFieldSpecified;
            }
            set
            {
                this.itemCategoryIdFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class RelatedItemsStruct
    {
        
        private RelatedItemStruct[] relatedItemsInfoField;
        
        private float relatedItemsAmountField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public RelatedItemStruct[] relatedItemsInfo
        {
            get
            {
                return this.relatedItemsInfoField;
            }
            set
            {
                this.relatedItemsInfoField = value;
            }
        }
        
        /// <remarks/>
        public float relatedItemsAmount
        {
            get
            {
                return this.relatedItemsAmountField;
            }
            set
            {
                this.relatedItemsAmountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ReasonInfoType
    {
        
        private int reasonIdField;
        
        private string reasonNameField;
        
        private int maxQuantityField;
        
        private bool maxQuantityFieldSpecified;
        
        /// <remarks/>
        public int reasonId
        {
            get
            {
                return this.reasonIdField;
            }
            set
            {
                this.reasonIdField = value;
            }
        }
        
        /// <remarks/>
        public string reasonName
        {
            get
            {
                return this.reasonNameField;
            }
            set
            {
                this.reasonNameField = value;
            }
        }
        
        /// <remarks/>
        public int maxQuantity
        {
            get
            {
                return this.maxQuantityField;
            }
            set
            {
                this.maxQuantityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool maxQuantitySpecified
        {
            get
            {
                return this.maxQuantityFieldSpecified;
            }
            set
            {
                this.maxQuantityFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class RefundDetailsType
    {
        
        private int refundIdField;
        
        private string refundStatusField;
        
        private int refundQuantityField;
        
        private System.DateTime createdDateField;
        
        private System.DateTime considerDateField;
        
        /// <remarks/>
        public int refundId
        {
            get
            {
                return this.refundIdField;
            }
            set
            {
                this.refundIdField = value;
            }
        }
        
        /// <remarks/>
        public string refundStatus
        {
            get
            {
                return this.refundStatusField;
            }
            set
            {
                this.refundStatusField = value;
            }
        }
        
        /// <remarks/>
        public int refundQuantity
        {
            get
            {
                return this.refundQuantityField;
            }
            set
            {
                this.refundQuantityField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime createdDate
        {
            get
            {
                return this.createdDateField;
            }
            set
            {
                this.createdDateField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime considerDate
        {
            get
            {
                return this.considerDateField;
            }
            set
            {
                this.considerDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class RefundListType
    {
        
        private long dealIdField;
        
        private System.DateTime dealDateField;
        
        private int buyerIdField;
        
        private string buyerLoginField;
        
        private long itemIdField;
        
        private string itemTitleField;
        
        private int bidsCountField;
        
        private string quantityTypeField;
        
        private RefundDetailsType refundDetailsField;
        
        /// <remarks/>
        public long dealId
        {
            get
            {
                return this.dealIdField;
            }
            set
            {
                this.dealIdField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime dealDate
        {
            get
            {
                return this.dealDateField;
            }
            set
            {
                this.dealDateField = value;
            }
        }
        
        /// <remarks/>
        public int buyerId
        {
            get
            {
                return this.buyerIdField;
            }
            set
            {
                this.buyerIdField = value;
            }
        }
        
        /// <remarks/>
        public string buyerLogin
        {
            get
            {
                return this.buyerLoginField;
            }
            set
            {
                this.buyerLoginField = value;
            }
        }
        
        /// <remarks/>
        public long itemId
        {
            get
            {
                return this.itemIdField;
            }
            set
            {
                this.itemIdField = value;
            }
        }
        
        /// <remarks/>
        public string itemTitle
        {
            get
            {
                return this.itemTitleField;
            }
            set
            {
                this.itemTitleField = value;
            }
        }
        
        /// <remarks/>
        public int bidsCount
        {
            get
            {
                return this.bidsCountField;
            }
            set
            {
                this.bidsCountField = value;
            }
        }
        
        /// <remarks/>
        public string quantityType
        {
            get
            {
                return this.quantityTypeField;
            }
            set
            {
                this.quantityTypeField = value;
            }
        }
        
        /// <remarks/>
        public RefundDetailsType refundDetails
        {
            get
            {
                return this.refundDetailsField;
            }
            set
            {
                this.refundDetailsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class RefundsDealsListType
    {
        
        private long dealIdField;
        
        private System.DateTime dealDateField;
        
        private int timeLeftField;
        
        private int buyerIdField;
        
        private string buyerLoginField;
        
        private long itemIdField;
        
        private string itemTitleField;
        
        private int bidsCountField;
        
        private string quantityTypeField;
        
        private string paymentStatusField;
        
        /// <remarks/>
        public long dealId
        {
            get
            {
                return this.dealIdField;
            }
            set
            {
                this.dealIdField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime dealDate
        {
            get
            {
                return this.dealDateField;
            }
            set
            {
                this.dealDateField = value;
            }
        }
        
        /// <remarks/>
        public int timeLeft
        {
            get
            {
                return this.timeLeftField;
            }
            set
            {
                this.timeLeftField = value;
            }
        }
        
        /// <remarks/>
        public int buyerId
        {
            get
            {
                return this.buyerIdField;
            }
            set
            {
                this.buyerIdField = value;
            }
        }
        
        /// <remarks/>
        public string buyerLogin
        {
            get
            {
                return this.buyerLoginField;
            }
            set
            {
                this.buyerLoginField = value;
            }
        }
        
        /// <remarks/>
        public long itemId
        {
            get
            {
                return this.itemIdField;
            }
            set
            {
                this.itemIdField = value;
            }
        }
        
        /// <remarks/>
        public string itemTitle
        {
            get
            {
                return this.itemTitleField;
            }
            set
            {
                this.itemTitleField = value;
            }
        }
        
        /// <remarks/>
        public int bidsCount
        {
            get
            {
                return this.bidsCountField;
            }
            set
            {
                this.bidsCountField = value;
            }
        }
        
        /// <remarks/>
        public string quantityType
        {
            get
            {
                return this.quantityTypeField;
            }
            set
            {
                this.quantityTypeField = value;
            }
        }
        
        /// <remarks/>
        public string paymentStatus
        {
            get
            {
                return this.paymentStatusField;
            }
            set
            {
                this.paymentStatusField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PostBuyItemInfoStruct
    {
        
        private long itemIdField;
        
        private int itemPostBuyFormInfoField;
        
        /// <remarks/>
        public long itemId
        {
            get
            {
                return this.itemIdField;
            }
            set
            {
                this.itemIdField = value;
            }
        }
        
        /// <remarks/>
        public int itemPostBuyFormInfo
        {
            get
            {
                return this.itemPostBuyFormInfoField;
            }
            set
            {
                this.itemPostBuyFormInfoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PostBuyFormDataStruct
    {
        
        private long postBuyFormIdField;
        
        private PostBuyFormItemStruct[] postBuyFormItemsField;
        
        private long postBuyFormBuyerIdField;
        
        private float postBuyFormAmountField;
        
        private float postBuyFormPostageAmountField;
        
        private int postBuyFormInvoiceOptionField;
        
        private string postBuyFormMsgToSellerField;
        
        private PostBuyFormAddressStruct postBuyFormInvoiceDataField;
        
        private PostBuyFormAddressStruct postBuyFormShipmentAddressField;
        
        private string postBuyFormPayTypeField;
        
        private long postBuyFormPayIdField;
        
        private string postBuyFormPayStatusField;
        
        private string postBuyFormDateInitField;
        
        private string postBuyFormDateRecvField;
        
        private string postBuyFormDateCancelField;
        
        private int postBuyFormShipmentIdField;
        
        private PostBuyFormAddressStruct postBuyFormGdAddressField;
        
        private PostBuyFormShipmentTrackingStruct[] postBuyFormShipmentTrackingField;
        
        private long[] postBuyFormSurchargesListField;
        
        private string postBuyFormGdAdditionalInfoField;
        
        private float postBuyFormPaymentAmountField;
        
        private int postBuyFormSentBySellerField;
        
        private string postBuyFormBuyerLoginField;
        
        private string postBuyFormBuyerEmailField;
        
        private float postBuyFormAdditionalServicesAmountField;
        
        /// <remarks/>
        public long postBuyFormId
        {
            get
            {
                return this.postBuyFormIdField;
            }
            set
            {
                this.postBuyFormIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public PostBuyFormItemStruct[] postBuyFormItems
        {
            get
            {
                return this.postBuyFormItemsField;
            }
            set
            {
                this.postBuyFormItemsField = value;
            }
        }
        
        /// <remarks/>
        public long postBuyFormBuyerId
        {
            get
            {
                return this.postBuyFormBuyerIdField;
            }
            set
            {
                this.postBuyFormBuyerIdField = value;
            }
        }
        
        /// <remarks/>
        public float postBuyFormAmount
        {
            get
            {
                return this.postBuyFormAmountField;
            }
            set
            {
                this.postBuyFormAmountField = value;
            }
        }
        
        /// <remarks/>
        public float postBuyFormPostageAmount
        {
            get
            {
                return this.postBuyFormPostageAmountField;
            }
            set
            {
                this.postBuyFormPostageAmountField = value;
            }
        }
        
        /// <remarks/>
        public int postBuyFormInvoiceOption
        {
            get
            {
                return this.postBuyFormInvoiceOptionField;
            }
            set
            {
                this.postBuyFormInvoiceOptionField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormMsgToSeller
        {
            get
            {
                return this.postBuyFormMsgToSellerField;
            }
            set
            {
                this.postBuyFormMsgToSellerField = value;
            }
        }
        
        /// <remarks/>
        public PostBuyFormAddressStruct postBuyFormInvoiceData
        {
            get
            {
                return this.postBuyFormInvoiceDataField;
            }
            set
            {
                this.postBuyFormInvoiceDataField = value;
            }
        }
        
        /// <remarks/>
        public PostBuyFormAddressStruct postBuyFormShipmentAddress
        {
            get
            {
                return this.postBuyFormShipmentAddressField;
            }
            set
            {
                this.postBuyFormShipmentAddressField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormPayType
        {
            get
            {
                return this.postBuyFormPayTypeField;
            }
            set
            {
                this.postBuyFormPayTypeField = value;
            }
        }
        
        /// <remarks/>
        public long postBuyFormPayId
        {
            get
            {
                return this.postBuyFormPayIdField;
            }
            set
            {
                this.postBuyFormPayIdField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormPayStatus
        {
            get
            {
                return this.postBuyFormPayStatusField;
            }
            set
            {
                this.postBuyFormPayStatusField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormDateInit
        {
            get
            {
                return this.postBuyFormDateInitField;
            }
            set
            {
                this.postBuyFormDateInitField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormDateRecv
        {
            get
            {
                return this.postBuyFormDateRecvField;
            }
            set
            {
                this.postBuyFormDateRecvField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormDateCancel
        {
            get
            {
                return this.postBuyFormDateCancelField;
            }
            set
            {
                this.postBuyFormDateCancelField = value;
            }
        }
        
        /// <remarks/>
        public int postBuyFormShipmentId
        {
            get
            {
                return this.postBuyFormShipmentIdField;
            }
            set
            {
                this.postBuyFormShipmentIdField = value;
            }
        }
        
        /// <remarks/>
        public PostBuyFormAddressStruct postBuyFormGdAddress
        {
            get
            {
                return this.postBuyFormGdAddressField;
            }
            set
            {
                this.postBuyFormGdAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public PostBuyFormShipmentTrackingStruct[] postBuyFormShipmentTracking
        {
            get
            {
                return this.postBuyFormShipmentTrackingField;
            }
            set
            {
                this.postBuyFormShipmentTrackingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] postBuyFormSurchargesList
        {
            get
            {
                return this.postBuyFormSurchargesListField;
            }
            set
            {
                this.postBuyFormSurchargesListField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormGdAdditionalInfo
        {
            get
            {
                return this.postBuyFormGdAdditionalInfoField;
            }
            set
            {
                this.postBuyFormGdAdditionalInfoField = value;
            }
        }
        
        /// <remarks/>
        public float postBuyFormPaymentAmount
        {
            get
            {
                return this.postBuyFormPaymentAmountField;
            }
            set
            {
                this.postBuyFormPaymentAmountField = value;
            }
        }
        
        /// <remarks/>
        public int postBuyFormSentBySeller
        {
            get
            {
                return this.postBuyFormSentBySellerField;
            }
            set
            {
                this.postBuyFormSentBySellerField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormBuyerLogin
        {
            get
            {
                return this.postBuyFormBuyerLoginField;
            }
            set
            {
                this.postBuyFormBuyerLoginField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormBuyerEmail
        {
            get
            {
                return this.postBuyFormBuyerEmailField;
            }
            set
            {
                this.postBuyFormBuyerEmailField = value;
            }
        }
        
        /// <remarks/>
        public float postBuyFormAdditionalServicesAmount
        {
            get
            {
                return this.postBuyFormAdditionalServicesAmountField;
            }
            set
            {
                this.postBuyFormAdditionalServicesAmountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PostBuyFormItemStruct
    {
        
        private int postBuyFormItQuantityField;
        
        private float postBuyFormItAmountField;
        
        private long postBuyFormItIdField;
        
        private string postBuyFormItTitleField;
        
        private int postBuyFormItCountryField;
        
        private float postBuyFormItPriceField;
        
        private PostBuyFormItemDealsStruct[] postBuyFormItDealsField;
        
        /// <remarks/>
        public int postBuyFormItQuantity
        {
            get
            {
                return this.postBuyFormItQuantityField;
            }
            set
            {
                this.postBuyFormItQuantityField = value;
            }
        }
        
        /// <remarks/>
        public float postBuyFormItAmount
        {
            get
            {
                return this.postBuyFormItAmountField;
            }
            set
            {
                this.postBuyFormItAmountField = value;
            }
        }
        
        /// <remarks/>
        public long postBuyFormItId
        {
            get
            {
                return this.postBuyFormItIdField;
            }
            set
            {
                this.postBuyFormItIdField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormItTitle
        {
            get
            {
                return this.postBuyFormItTitleField;
            }
            set
            {
                this.postBuyFormItTitleField = value;
            }
        }
        
        /// <remarks/>
        public int postBuyFormItCountry
        {
            get
            {
                return this.postBuyFormItCountryField;
            }
            set
            {
                this.postBuyFormItCountryField = value;
            }
        }
        
        /// <remarks/>
        public float postBuyFormItPrice
        {
            get
            {
                return this.postBuyFormItPriceField;
            }
            set
            {
                this.postBuyFormItPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public PostBuyFormItemDealsStruct[] postBuyFormItDeals
        {
            get
            {
                return this.postBuyFormItDealsField;
            }
            set
            {
                this.postBuyFormItDealsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PostBuyFormItemDealsStruct
    {
        
        private long dealIdField;
        
        private float dealFinalPriceField;
        
        private int dealQuantityField;
        
        private System.DateTime dealDateField;
        
        private bool dealWasDiscountedField;
        
        private PostBuyFormItemDealsVariantStruct dealVariantField;
        
        private PostBuyFormItemDealsAdditionalServiceStruct[] dealAdditionalServicesField;
        
        /// <remarks/>
        public long dealId
        {
            get
            {
                return this.dealIdField;
            }
            set
            {
                this.dealIdField = value;
            }
        }
        
        /// <remarks/>
        public float dealFinalPrice
        {
            get
            {
                return this.dealFinalPriceField;
            }
            set
            {
                this.dealFinalPriceField = value;
            }
        }
        
        /// <remarks/>
        public int dealQuantity
        {
            get
            {
                return this.dealQuantityField;
            }
            set
            {
                this.dealQuantityField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime dealDate
        {
            get
            {
                return this.dealDateField;
            }
            set
            {
                this.dealDateField = value;
            }
        }
        
        /// <remarks/>
        public bool dealWasDiscounted
        {
            get
            {
                return this.dealWasDiscountedField;
            }
            set
            {
                this.dealWasDiscountedField = value;
            }
        }
        
        /// <remarks/>
        public PostBuyFormItemDealsVariantStruct dealVariant
        {
            get
            {
                return this.dealVariantField;
            }
            set
            {
                this.dealVariantField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public PostBuyFormItemDealsAdditionalServiceStruct[] dealAdditionalServices
        {
            get
            {
                return this.dealAdditionalServicesField;
            }
            set
            {
                this.dealAdditionalServicesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PostBuyFormItemDealsVariantStruct
    {
        
        private string variantNameField;
        
        private string variantValueField;
        
        /// <remarks/>
        public string variantName
        {
            get
            {
                return this.variantNameField;
            }
            set
            {
                this.variantNameField = value;
            }
        }
        
        /// <remarks/>
        public string variantValue
        {
            get
            {
                return this.variantValueField;
            }
            set
            {
                this.variantValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PostBuyFormItemDealsAdditionalServiceStruct
    {
        
        private string additionalServiceDefinitionIdField;
        
        private string additionalServiceNameField;
        
        private int additionalServiceQuantityField;
        
        private float additionalServicePriceField;
        
        /// <remarks/>
        public string additionalServiceDefinitionId
        {
            get
            {
                return this.additionalServiceDefinitionIdField;
            }
            set
            {
                this.additionalServiceDefinitionIdField = value;
            }
        }
        
        /// <remarks/>
        public string additionalServiceName
        {
            get
            {
                return this.additionalServiceNameField;
            }
            set
            {
                this.additionalServiceNameField = value;
            }
        }
        
        /// <remarks/>
        public int additionalServiceQuantity
        {
            get
            {
                return this.additionalServiceQuantityField;
            }
            set
            {
                this.additionalServiceQuantityField = value;
            }
        }
        
        /// <remarks/>
        public float additionalServicePrice
        {
            get
            {
                return this.additionalServicePriceField;
            }
            set
            {
                this.additionalServicePriceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PostBuyFormAddressStruct
    {
        
        private int postBuyFormAdrCountryField;
        
        private string postBuyFormAdrStreetField;
        
        private string postBuyFormAdrPostcodeField;
        
        private string postBuyFormAdrCityField;
        
        private string postBuyFormAdrFullNameField;
        
        private string postBuyFormAdrCompanyField;
        
        private string postBuyFormAdrPhoneField;
        
        private string postBuyFormAdrNipField;
        
        private string postBuyFormCreatedDateField;
        
        private int postBuyFormAdrTypeField;
        
        /// <remarks/>
        public int postBuyFormAdrCountry
        {
            get
            {
                return this.postBuyFormAdrCountryField;
            }
            set
            {
                this.postBuyFormAdrCountryField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormAdrStreet
        {
            get
            {
                return this.postBuyFormAdrStreetField;
            }
            set
            {
                this.postBuyFormAdrStreetField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormAdrPostcode
        {
            get
            {
                return this.postBuyFormAdrPostcodeField;
            }
            set
            {
                this.postBuyFormAdrPostcodeField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormAdrCity
        {
            get
            {
                return this.postBuyFormAdrCityField;
            }
            set
            {
                this.postBuyFormAdrCityField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormAdrFullName
        {
            get
            {
                return this.postBuyFormAdrFullNameField;
            }
            set
            {
                this.postBuyFormAdrFullNameField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormAdrCompany
        {
            get
            {
                return this.postBuyFormAdrCompanyField;
            }
            set
            {
                this.postBuyFormAdrCompanyField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormAdrPhone
        {
            get
            {
                return this.postBuyFormAdrPhoneField;
            }
            set
            {
                this.postBuyFormAdrPhoneField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormAdrNip
        {
            get
            {
                return this.postBuyFormAdrNipField;
            }
            set
            {
                this.postBuyFormAdrNipField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormCreatedDate
        {
            get
            {
                return this.postBuyFormCreatedDateField;
            }
            set
            {
                this.postBuyFormCreatedDateField = value;
            }
        }
        
        /// <remarks/>
        public int postBuyFormAdrType
        {
            get
            {
                return this.postBuyFormAdrTypeField;
            }
            set
            {
                this.postBuyFormAdrTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PostBuyFormShipmentTrackingStruct
    {
        
        private int postBuyFormOperatorIdField;
        
        private string postBuyFormPackageIdField;
        
        private string postBuyFormPackageStatusField;
        
        /// <remarks/>
        public int postBuyFormOperatorId
        {
            get
            {
                return this.postBuyFormOperatorIdField;
            }
            set
            {
                this.postBuyFormOperatorIdField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormPackageId
        {
            get
            {
                return this.postBuyFormPackageIdField;
            }
            set
            {
                this.postBuyFormPackageIdField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormPackageStatus
        {
            get
            {
                return this.postBuyFormPackageStatusField;
            }
            set
            {
                this.postBuyFormPackageStatusField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PostBuyFormSellersStruct
    {
        
        private int postBuyFormSellerIdField;
        
        private string postBuyFormSellerNameField;
        
        private PostBuyFormItemStruct[] postBuyFormItemsField;
        
        private int postBuyFormShipmentIdField;
        
        private float postBuyFormPostageAmountField;
        
        private string postBuyFormMsgToSellerField;
        
        private float postBuyFormAmountField;
        
        private long[] postBuyFormSurchargesListField;
        
        private PostBuyFormShipmentTrackingStruct[] postBuyFormShipmentTrackingField;
        
        private PostBuyFormAddressStruct postBuyFormGdAddressField;
        
        private string postBuyFormGdAdditionalInfoField;
        
        private int postBuyFormSentBySellerField;
        
        /// <remarks/>
        public int postBuyFormSellerId
        {
            get
            {
                return this.postBuyFormSellerIdField;
            }
            set
            {
                this.postBuyFormSellerIdField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormSellerName
        {
            get
            {
                return this.postBuyFormSellerNameField;
            }
            set
            {
                this.postBuyFormSellerNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public PostBuyFormItemStruct[] postBuyFormItems
        {
            get
            {
                return this.postBuyFormItemsField;
            }
            set
            {
                this.postBuyFormItemsField = value;
            }
        }
        
        /// <remarks/>
        public int postBuyFormShipmentId
        {
            get
            {
                return this.postBuyFormShipmentIdField;
            }
            set
            {
                this.postBuyFormShipmentIdField = value;
            }
        }
        
        /// <remarks/>
        public float postBuyFormPostageAmount
        {
            get
            {
                return this.postBuyFormPostageAmountField;
            }
            set
            {
                this.postBuyFormPostageAmountField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormMsgToSeller
        {
            get
            {
                return this.postBuyFormMsgToSellerField;
            }
            set
            {
                this.postBuyFormMsgToSellerField = value;
            }
        }
        
        /// <remarks/>
        public float postBuyFormAmount
        {
            get
            {
                return this.postBuyFormAmountField;
            }
            set
            {
                this.postBuyFormAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] postBuyFormSurchargesList
        {
            get
            {
                return this.postBuyFormSurchargesListField;
            }
            set
            {
                this.postBuyFormSurchargesListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public PostBuyFormShipmentTrackingStruct[] postBuyFormShipmentTracking
        {
            get
            {
                return this.postBuyFormShipmentTrackingField;
            }
            set
            {
                this.postBuyFormShipmentTrackingField = value;
            }
        }
        
        /// <remarks/>
        public PostBuyFormAddressStruct postBuyFormGdAddress
        {
            get
            {
                return this.postBuyFormGdAddressField;
            }
            set
            {
                this.postBuyFormGdAddressField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormGdAdditionalInfo
        {
            get
            {
                return this.postBuyFormGdAdditionalInfoField;
            }
            set
            {
                this.postBuyFormGdAdditionalInfoField = value;
            }
        }
        
        /// <remarks/>
        public int postBuyFormSentBySeller
        {
            get
            {
                return this.postBuyFormSentBySellerField;
            }
            set
            {
                this.postBuyFormSentBySellerField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PostBuyFormForBuyersDataStruct
    {
        
        private long postBuyFormIdField;
        
        private int postBuyFormBuyerIdField;
        
        private PostBuyFormSellersStruct[] postBuyFormSellersField;
        
        private float postBuyFormTotalAmountField;
        
        private int postBuyFormInvoiceOptionField;
        
        private PostBuyFormAddressStruct postBuyFormInvoiceDataField;
        
        private PostBuyFormAddressStruct postBuyFormShipmentAddressField;
        
        private string postBuyFormPayTypeField;
        
        private long postBuyFormPayIdField;
        
        private string postBuyFormPayStatusField;
        
        private string postBuyFormDateInitField;
        
        private string postBuyFormDateRecvField;
        
        private string postBuyFormDateCancelField;
        
        private float postBuyFormPaymentAmountField;
        
        /// <remarks/>
        public long postBuyFormId
        {
            get
            {
                return this.postBuyFormIdField;
            }
            set
            {
                this.postBuyFormIdField = value;
            }
        }
        
        /// <remarks/>
        public int postBuyFormBuyerId
        {
            get
            {
                return this.postBuyFormBuyerIdField;
            }
            set
            {
                this.postBuyFormBuyerIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public PostBuyFormSellersStruct[] postBuyFormSellers
        {
            get
            {
                return this.postBuyFormSellersField;
            }
            set
            {
                this.postBuyFormSellersField = value;
            }
        }
        
        /// <remarks/>
        public float postBuyFormTotalAmount
        {
            get
            {
                return this.postBuyFormTotalAmountField;
            }
            set
            {
                this.postBuyFormTotalAmountField = value;
            }
        }
        
        /// <remarks/>
        public int postBuyFormInvoiceOption
        {
            get
            {
                return this.postBuyFormInvoiceOptionField;
            }
            set
            {
                this.postBuyFormInvoiceOptionField = value;
            }
        }
        
        /// <remarks/>
        public PostBuyFormAddressStruct postBuyFormInvoiceData
        {
            get
            {
                return this.postBuyFormInvoiceDataField;
            }
            set
            {
                this.postBuyFormInvoiceDataField = value;
            }
        }
        
        /// <remarks/>
        public PostBuyFormAddressStruct postBuyFormShipmentAddress
        {
            get
            {
                return this.postBuyFormShipmentAddressField;
            }
            set
            {
                this.postBuyFormShipmentAddressField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormPayType
        {
            get
            {
                return this.postBuyFormPayTypeField;
            }
            set
            {
                this.postBuyFormPayTypeField = value;
            }
        }
        
        /// <remarks/>
        public long postBuyFormPayId
        {
            get
            {
                return this.postBuyFormPayIdField;
            }
            set
            {
                this.postBuyFormPayIdField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormPayStatus
        {
            get
            {
                return this.postBuyFormPayStatusField;
            }
            set
            {
                this.postBuyFormPayStatusField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormDateInit
        {
            get
            {
                return this.postBuyFormDateInitField;
            }
            set
            {
                this.postBuyFormDateInitField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormDateRecv
        {
            get
            {
                return this.postBuyFormDateRecvField;
            }
            set
            {
                this.postBuyFormDateRecvField = value;
            }
        }
        
        /// <remarks/>
        public string postBuyFormDateCancel
        {
            get
            {
                return this.postBuyFormDateCancelField;
            }
            set
            {
                this.postBuyFormDateCancelField = value;
            }
        }
        
        /// <remarks/>
        public float postBuyFormPaymentAmount
        {
            get
            {
                return this.postBuyFormPaymentAmountField;
            }
            set
            {
                this.postBuyFormPaymentAmountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class UserSentToDataStruct
    {
        
        private long userIdField;
        
        private string userFirstNameField;
        
        private string userLastNameField;
        
        private string userCompanyField;
        
        private int userCountryIdField;
        
        private string userPostcodeField;
        
        private string userCityField;
        
        private string userAddressField;
        
        /// <remarks/>
        public long userId
        {
            get
            {
                return this.userIdField;
            }
            set
            {
                this.userIdField = value;
            }
        }
        
        /// <remarks/>
        public string userFirstName
        {
            get
            {
                return this.userFirstNameField;
            }
            set
            {
                this.userFirstNameField = value;
            }
        }
        
        /// <remarks/>
        public string userLastName
        {
            get
            {
                return this.userLastNameField;
            }
            set
            {
                this.userLastNameField = value;
            }
        }
        
        /// <remarks/>
        public string userCompany
        {
            get
            {
                return this.userCompanyField;
            }
            set
            {
                this.userCompanyField = value;
            }
        }
        
        /// <remarks/>
        public int userCountryId
        {
            get
            {
                return this.userCountryIdField;
            }
            set
            {
                this.userCountryIdField = value;
            }
        }
        
        /// <remarks/>
        public string userPostcode
        {
            get
            {
                return this.userPostcodeField;
            }
            set
            {
                this.userPostcodeField = value;
            }
        }
        
        /// <remarks/>
        public string userCity
        {
            get
            {
                return this.userCityField;
            }
            set
            {
                this.userCityField = value;
            }
        }
        
        /// <remarks/>
        public string userAddress
        {
            get
            {
                return this.userAddressField;
            }
            set
            {
                this.userAddressField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class UserPostBuyDataStruct
    {
        
        private UserDataStruct userDataField;
        
        private UserSentToDataStruct userSentToDataField;
        
        private string[] userBankAccountsField;
        
        private CompanySecondAddressStruct companySecondAddressField;
        
        /// <remarks/>
        public UserDataStruct userData
        {
            get
            {
                return this.userDataField;
            }
            set
            {
                this.userDataField = value;
            }
        }
        
        /// <remarks/>
        public UserSentToDataStruct userSentToData
        {
            get
            {
                return this.userSentToDataField;
            }
            set
            {
                this.userSentToDataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public string[] userBankAccounts
        {
            get
            {
                return this.userBankAccountsField;
            }
            set
            {
                this.userBankAccountsField = value;
            }
        }
        
        /// <remarks/>
        public CompanySecondAddressStruct companySecondAddress
        {
            get
            {
                return this.companySecondAddressField;
            }
            set
            {
                this.companySecondAddressField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class UserDataStruct
    {
        
        private long userIdField;
        
        private string userLoginField;
        
        private int userRatingField;
        
        private string userFirstNameField;
        
        private string userLastNameField;
        
        private string userMaidenNameField;
        
        private string userCompanyField;
        
        private int userCountryIdField;
        
        private int userStateIdField;
        
        private string userPostcodeField;
        
        private string userCityField;
        
        private string userAddressField;
        
        private string userEmailField;
        
        private string userPhoneField;
        
        private string userPhone2Field;
        
        private int userSsStatusField;
        
        private int siteCountryIdField;
        
        private int userJuniorStatusField;
        
        private long userBirthDateField;
        
        private int userHasShopField;
        
        private int userCompanyIconField;
        
        private int userIsAllegroStandardField;
        
        /// <remarks/>
        public long userId
        {
            get
            {
                return this.userIdField;
            }
            set
            {
                this.userIdField = value;
            }
        }
        
        /// <remarks/>
        public string userLogin
        {
            get
            {
                return this.userLoginField;
            }
            set
            {
                this.userLoginField = value;
            }
        }
        
        /// <remarks/>
        public int userRating
        {
            get
            {
                return this.userRatingField;
            }
            set
            {
                this.userRatingField = value;
            }
        }
        
        /// <remarks/>
        public string userFirstName
        {
            get
            {
                return this.userFirstNameField;
            }
            set
            {
                this.userFirstNameField = value;
            }
        }
        
        /// <remarks/>
        public string userLastName
        {
            get
            {
                return this.userLastNameField;
            }
            set
            {
                this.userLastNameField = value;
            }
        }
        
        /// <remarks/>
        public string userMaidenName
        {
            get
            {
                return this.userMaidenNameField;
            }
            set
            {
                this.userMaidenNameField = value;
            }
        }
        
        /// <remarks/>
        public string userCompany
        {
            get
            {
                return this.userCompanyField;
            }
            set
            {
                this.userCompanyField = value;
            }
        }
        
        /// <remarks/>
        public int userCountryId
        {
            get
            {
                return this.userCountryIdField;
            }
            set
            {
                this.userCountryIdField = value;
            }
        }
        
        /// <remarks/>
        public int userStateId
        {
            get
            {
                return this.userStateIdField;
            }
            set
            {
                this.userStateIdField = value;
            }
        }
        
        /// <remarks/>
        public string userPostcode
        {
            get
            {
                return this.userPostcodeField;
            }
            set
            {
                this.userPostcodeField = value;
            }
        }
        
        /// <remarks/>
        public string userCity
        {
            get
            {
                return this.userCityField;
            }
            set
            {
                this.userCityField = value;
            }
        }
        
        /// <remarks/>
        public string userAddress
        {
            get
            {
                return this.userAddressField;
            }
            set
            {
                this.userAddressField = value;
            }
        }
        
        /// <remarks/>
        public string userEmail
        {
            get
            {
                return this.userEmailField;
            }
            set
            {
                this.userEmailField = value;
            }
        }
        
        /// <remarks/>
        public string userPhone
        {
            get
            {
                return this.userPhoneField;
            }
            set
            {
                this.userPhoneField = value;
            }
        }
        
        /// <remarks/>
        public string userPhone2
        {
            get
            {
                return this.userPhone2Field;
            }
            set
            {
                this.userPhone2Field = value;
            }
        }
        
        /// <remarks/>
        public int userSsStatus
        {
            get
            {
                return this.userSsStatusField;
            }
            set
            {
                this.userSsStatusField = value;
            }
        }
        
        /// <remarks/>
        public int siteCountryId
        {
            get
            {
                return this.siteCountryIdField;
            }
            set
            {
                this.siteCountryIdField = value;
            }
        }
        
        /// <remarks/>
        public int userJuniorStatus
        {
            get
            {
                return this.userJuniorStatusField;
            }
            set
            {
                this.userJuniorStatusField = value;
            }
        }
        
        /// <remarks/>
        public long userBirthDate
        {
            get
            {
                return this.userBirthDateField;
            }
            set
            {
                this.userBirthDateField = value;
            }
        }
        
        /// <remarks/>
        public int userHasShop
        {
            get
            {
                return this.userHasShopField;
            }
            set
            {
                this.userHasShopField = value;
            }
        }
        
        /// <remarks/>
        public int userCompanyIcon
        {
            get
            {
                return this.userCompanyIconField;
            }
            set
            {
                this.userCompanyIconField = value;
            }
        }
        
        /// <remarks/>
        public int userIsAllegroStandard
        {
            get
            {
                return this.userIsAllegroStandardField;
            }
            set
            {
                this.userIsAllegroStandardField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class CompanySecondAddressStruct
    {
        
        private string companyWorkerFirstNameField;
        
        private string companyWorkerLastNameField;
        
        private string companyAddressField;
        
        private string companyPostcodeField;
        
        private string companyCityField;
        
        private int companyCountryIdField;
        
        private int companyStateIdField;
        
        /// <remarks/>
        public string companyWorkerFirstName
        {
            get
            {
                return this.companyWorkerFirstNameField;
            }
            set
            {
                this.companyWorkerFirstNameField = value;
            }
        }
        
        /// <remarks/>
        public string companyWorkerLastName
        {
            get
            {
                return this.companyWorkerLastNameField;
            }
            set
            {
                this.companyWorkerLastNameField = value;
            }
        }
        
        /// <remarks/>
        public string companyAddress
        {
            get
            {
                return this.companyAddressField;
            }
            set
            {
                this.companyAddressField = value;
            }
        }
        
        /// <remarks/>
        public string companyPostcode
        {
            get
            {
                return this.companyPostcodeField;
            }
            set
            {
                this.companyPostcodeField = value;
            }
        }
        
        /// <remarks/>
        public string companyCity
        {
            get
            {
                return this.companyCityField;
            }
            set
            {
                this.companyCityField = value;
            }
        }
        
        /// <remarks/>
        public int companyCountryId
        {
            get
            {
                return this.companyCountryIdField;
            }
            set
            {
                this.companyCountryIdField = value;
            }
        }
        
        /// <remarks/>
        public int companyStateId
        {
            get
            {
                return this.companyStateIdField;
            }
            set
            {
                this.companyStateIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ItemPostBuyDataStruct
    {
        
        private long itemIdField;
        
        private UserPostBuyDataStruct[] usersPostBuyDataField;
        
        /// <remarks/>
        public long itemId
        {
            get
            {
                return this.itemIdField;
            }
            set
            {
                this.itemIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public UserPostBuyDataStruct[] usersPostBuyData
        {
            get
            {
                return this.usersPostBuyDataField;
            }
            set
            {
                this.usersPostBuyDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PaymentMethodStruct
    {
        
        private string paymentMethodIdField;
        
        private string paymentMethodNameField;
        
        private string paymentMethodImageField;
        
        private int paymentMethodUsageField;
        
        /// <remarks/>
        public string paymentMethodId
        {
            get
            {
                return this.paymentMethodIdField;
            }
            set
            {
                this.paymentMethodIdField = value;
            }
        }
        
        /// <remarks/>
        public string paymentMethodName
        {
            get
            {
                return this.paymentMethodNameField;
            }
            set
            {
                this.paymentMethodNameField = value;
            }
        }
        
        /// <remarks/>
        public string paymentMethodImage
        {
            get
            {
                return this.paymentMethodImageField;
            }
            set
            {
                this.paymentMethodImageField = value;
            }
        }
        
        /// <remarks/>
        public int paymentMethodUsage
        {
            get
            {
                return this.paymentMethodUsageField;
            }
            set
            {
                this.paymentMethodUsageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class WonItemStruct
    {
        
        private long itemIdField;
        
        private string itemTitleField;
        
        private string itemThumbnailUrlField;
        
        private ItemPriceStruct[] itemPriceField;
        
        private int itemBoughtQuantityField;
        
        private int itemLeftQuantityField;
        
        private int itemQuantityTypeField;
        
        private long itemEndTimeField;
        
        private string itemEndTimeLeftField;
        
        private UserInfoStruct itemSellerField;
        
        private int itemBiddersCounterField;
        
        private int itemCategoryIdField;
        
        private int itemViewsCounterField;
        
        private string itemNoteField;
        
        private int itemSpecialInfoField;
        
        private int itemShopInfoField;
        
        private long itemProductInfoField;
        
        private int itemPayuInfoField;
        
        /// <remarks/>
        public long itemId
        {
            get
            {
                return this.itemIdField;
            }
            set
            {
                this.itemIdField = value;
            }
        }
        
        /// <remarks/>
        public string itemTitle
        {
            get
            {
                return this.itemTitleField;
            }
            set
            {
                this.itemTitleField = value;
            }
        }
        
        /// <remarks/>
        public string itemThumbnailUrl
        {
            get
            {
                return this.itemThumbnailUrlField;
            }
            set
            {
                this.itemThumbnailUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public ItemPriceStruct[] itemPrice
        {
            get
            {
                return this.itemPriceField;
            }
            set
            {
                this.itemPriceField = value;
            }
        }
        
        /// <remarks/>
        public int itemBoughtQuantity
        {
            get
            {
                return this.itemBoughtQuantityField;
            }
            set
            {
                this.itemBoughtQuantityField = value;
            }
        }
        
        /// <remarks/>
        public int itemLeftQuantity
        {
            get
            {
                return this.itemLeftQuantityField;
            }
            set
            {
                this.itemLeftQuantityField = value;
            }
        }
        
        /// <remarks/>
        public int itemQuantityType
        {
            get
            {
                return this.itemQuantityTypeField;
            }
            set
            {
                this.itemQuantityTypeField = value;
            }
        }
        
        /// <remarks/>
        public long itemEndTime
        {
            get
            {
                return this.itemEndTimeField;
            }
            set
            {
                this.itemEndTimeField = value;
            }
        }
        
        /// <remarks/>
        public string itemEndTimeLeft
        {
            get
            {
                return this.itemEndTimeLeftField;
            }
            set
            {
                this.itemEndTimeLeftField = value;
            }
        }
        
        /// <remarks/>
        public UserInfoStruct itemSeller
        {
            get
            {
                return this.itemSellerField;
            }
            set
            {
                this.itemSellerField = value;
            }
        }
        
        /// <remarks/>
        public int itemBiddersCounter
        {
            get
            {
                return this.itemBiddersCounterField;
            }
            set
            {
                this.itemBiddersCounterField = value;
            }
        }
        
        /// <remarks/>
        public int itemCategoryId
        {
            get
            {
                return this.itemCategoryIdField;
            }
            set
            {
                this.itemCategoryIdField = value;
            }
        }
        
        /// <remarks/>
        public int itemViewsCounter
        {
            get
            {
                return this.itemViewsCounterField;
            }
            set
            {
                this.itemViewsCounterField = value;
            }
        }
        
        /// <remarks/>
        public string itemNote
        {
            get
            {
                return this.itemNoteField;
            }
            set
            {
                this.itemNoteField = value;
            }
        }
        
        /// <remarks/>
        public int itemSpecialInfo
        {
            get
            {
                return this.itemSpecialInfoField;
            }
            set
            {
                this.itemSpecialInfoField = value;
            }
        }
        
        /// <remarks/>
        public int itemShopInfo
        {
            get
            {
                return this.itemShopInfoField;
            }
            set
            {
                this.itemShopInfoField = value;
            }
        }
        
        /// <remarks/>
        public long itemProductInfo
        {
            get
            {
                return this.itemProductInfoField;
            }
            set
            {
                this.itemProductInfoField = value;
            }
        }
        
        /// <remarks/>
        public int itemPayuInfo
        {
            get
            {
                return this.itemPayuInfoField;
            }
            set
            {
                this.itemPayuInfoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ItemPriceStruct
    {
        
        private int priceTypeField;
        
        private float priceValueField;
        
        /// <remarks/>
        public int priceType
        {
            get
            {
                return this.priceTypeField;
            }
            set
            {
                this.priceTypeField = value;
            }
        }
        
        /// <remarks/>
        public float priceValue
        {
            get
            {
                return this.priceValueField;
            }
            set
            {
                this.priceValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class UserInfoStruct
    {
        
        private int userIdField;
        
        private string userLoginField;
        
        private int userRatingField;
        
        private int userIconsField;
        
        private int userCountryField;
        
        /// <remarks/>
        public int userId
        {
            get
            {
                return this.userIdField;
            }
            set
            {
                this.userIdField = value;
            }
        }
        
        /// <remarks/>
        public string userLogin
        {
            get
            {
                return this.userLoginField;
            }
            set
            {
                this.userLoginField = value;
            }
        }
        
        /// <remarks/>
        public int userRating
        {
            get
            {
                return this.userRatingField;
            }
            set
            {
                this.userRatingField = value;
            }
        }
        
        /// <remarks/>
        public int userIcons
        {
            get
            {
                return this.userIconsField;
            }
            set
            {
                this.userIconsField = value;
            }
        }
        
        /// <remarks/>
        public int userCountry
        {
            get
            {
                return this.userCountryField;
            }
            set
            {
                this.userCountryField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class SoldItemStruct
    {
        
        private long itemIdField;
        
        private string itemTitleField;
        
        private string itemThumbnailUrlField;
        
        private ItemPriceStruct[] itemPriceField;
        
        private int itemStartQuantityField;
        
        private int itemSoldQuantityField;
        
        private int itemQuantityTypeField;
        
        private long itemStartTimeField;
        
        private long itemEndTimeField;
        
        private string itemEndTimeLeftField;
        
        private int itemBiddersCounterField;
        
        private UserInfoStruct itemHighestBidderField;
        
        private int itemCategoryIdField;
        
        private int itemWatchersCounterField;
        
        private int itemViewsCounterField;
        
        private string itemNoteField;
        
        private int itemSpecialInfoField;
        
        private int itemShopInfoField;
        
        private long itemProductInfoField;
        
        private int itemPayuInfoField;
        
        private DurationInfoStruct itemDurationInfoField;
        
        /// <remarks/>
        public long itemId
        {
            get
            {
                return this.itemIdField;
            }
            set
            {
                this.itemIdField = value;
            }
        }
        
        /// <remarks/>
        public string itemTitle
        {
            get
            {
                return this.itemTitleField;
            }
            set
            {
                this.itemTitleField = value;
            }
        }
        
        /// <remarks/>
        public string itemThumbnailUrl
        {
            get
            {
                return this.itemThumbnailUrlField;
            }
            set
            {
                this.itemThumbnailUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public ItemPriceStruct[] itemPrice
        {
            get
            {
                return this.itemPriceField;
            }
            set
            {
                this.itemPriceField = value;
            }
        }
        
        /// <remarks/>
        public int itemStartQuantity
        {
            get
            {
                return this.itemStartQuantityField;
            }
            set
            {
                this.itemStartQuantityField = value;
            }
        }
        
        /// <remarks/>
        public int itemSoldQuantity
        {
            get
            {
                return this.itemSoldQuantityField;
            }
            set
            {
                this.itemSoldQuantityField = value;
            }
        }
        
        /// <remarks/>
        public int itemQuantityType
        {
            get
            {
                return this.itemQuantityTypeField;
            }
            set
            {
                this.itemQuantityTypeField = value;
            }
        }
        
        /// <remarks/>
        public long itemStartTime
        {
            get
            {
                return this.itemStartTimeField;
            }
            set
            {
                this.itemStartTimeField = value;
            }
        }
        
        /// <remarks/>
        public long itemEndTime
        {
            get
            {
                return this.itemEndTimeField;
            }
            set
            {
                this.itemEndTimeField = value;
            }
        }
        
        /// <remarks/>
        public string itemEndTimeLeft
        {
            get
            {
                return this.itemEndTimeLeftField;
            }
            set
            {
                this.itemEndTimeLeftField = value;
            }
        }
        
        /// <remarks/>
        public int itemBiddersCounter
        {
            get
            {
                return this.itemBiddersCounterField;
            }
            set
            {
                this.itemBiddersCounterField = value;
            }
        }
        
        /// <remarks/>
        public UserInfoStruct itemHighestBidder
        {
            get
            {
                return this.itemHighestBidderField;
            }
            set
            {
                this.itemHighestBidderField = value;
            }
        }
        
        /// <remarks/>
        public int itemCategoryId
        {
            get
            {
                return this.itemCategoryIdField;
            }
            set
            {
                this.itemCategoryIdField = value;
            }
        }
        
        /// <remarks/>
        public int itemWatchersCounter
        {
            get
            {
                return this.itemWatchersCounterField;
            }
            set
            {
                this.itemWatchersCounterField = value;
            }
        }
        
        /// <remarks/>
        public int itemViewsCounter
        {
            get
            {
                return this.itemViewsCounterField;
            }
            set
            {
                this.itemViewsCounterField = value;
            }
        }
        
        /// <remarks/>
        public string itemNote
        {
            get
            {
                return this.itemNoteField;
            }
            set
            {
                this.itemNoteField = value;
            }
        }
        
        /// <remarks/>
        public int itemSpecialInfo
        {
            get
            {
                return this.itemSpecialInfoField;
            }
            set
            {
                this.itemSpecialInfoField = value;
            }
        }
        
        /// <remarks/>
        public int itemShopInfo
        {
            get
            {
                return this.itemShopInfoField;
            }
            set
            {
                this.itemShopInfoField = value;
            }
        }
        
        /// <remarks/>
        public long itemProductInfo
        {
            get
            {
                return this.itemProductInfoField;
            }
            set
            {
                this.itemProductInfoField = value;
            }
        }
        
        /// <remarks/>
        public int itemPayuInfo
        {
            get
            {
                return this.itemPayuInfoField;
            }
            set
            {
                this.itemPayuInfoField = value;
            }
        }
        
        /// <remarks/>
        public DurationInfoStruct itemDurationInfo
        {
            get
            {
                return this.itemDurationInfoField;
            }
            set
            {
                this.itemDurationInfoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class DurationInfoStruct
    {
        
        private int durationTypeField;
        
        private bool durationTypeFieldSpecified;
        
        /// <remarks/>
        public int durationType
        {
            get
            {
                return this.durationTypeField;
            }
            set
            {
                this.durationTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool durationTypeSpecified
        {
            get
            {
                return this.durationTypeFieldSpecified;
            }
            set
            {
                this.durationTypeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class SoldFilterOptionsStruct
    {
        
        private int filterFormatField;
        
        private bool filterFormatFieldSpecified;
        
        private int filterFromEndField;
        
        private bool filterFromEndFieldSpecified;
        
        private int filterAutoListingField;
        
        private bool filterAutoListingFieldSpecified;
        
        private FilterPriceStruct filterPriceField;
        
        private int filterDurationTypeField;
        
        private bool filterDurationTypeFieldSpecified;
        
        /// <remarks/>
        public int filterFormat
        {
            get
            {
                return this.filterFormatField;
            }
            set
            {
                this.filterFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool filterFormatSpecified
        {
            get
            {
                return this.filterFormatFieldSpecified;
            }
            set
            {
                this.filterFormatFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int filterFromEnd
        {
            get
            {
                return this.filterFromEndField;
            }
            set
            {
                this.filterFromEndField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool filterFromEndSpecified
        {
            get
            {
                return this.filterFromEndFieldSpecified;
            }
            set
            {
                this.filterFromEndFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int filterAutoListing
        {
            get
            {
                return this.filterAutoListingField;
            }
            set
            {
                this.filterAutoListingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool filterAutoListingSpecified
        {
            get
            {
                return this.filterAutoListingFieldSpecified;
            }
            set
            {
                this.filterAutoListingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public FilterPriceStruct filterPrice
        {
            get
            {
                return this.filterPriceField;
            }
            set
            {
                this.filterPriceField = value;
            }
        }
        
        /// <remarks/>
        public int filterDurationType
        {
            get
            {
                return this.filterDurationTypeField;
            }
            set
            {
                this.filterDurationTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool filterDurationTypeSpecified
        {
            get
            {
                return this.filterDurationTypeFieldSpecified;
            }
            set
            {
                this.filterDurationTypeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class FilterPriceStruct
    {
        
        private float filterPriceFromField;
        
        private bool filterPriceFromFieldSpecified;
        
        private float filterPriceToField;
        
        private bool filterPriceToFieldSpecified;
        
        /// <remarks/>
        public float filterPriceFrom
        {
            get
            {
                return this.filterPriceFromField;
            }
            set
            {
                this.filterPriceFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool filterPriceFromSpecified
        {
            get
            {
                return this.filterPriceFromFieldSpecified;
            }
            set
            {
                this.filterPriceFromFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public float filterPriceTo
        {
            get
            {
                return this.filterPriceToField;
            }
            set
            {
                this.filterPriceToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool filterPriceToSpecified
        {
            get
            {
                return this.filterPriceToFieldSpecified;
            }
            set
            {
                this.filterPriceToFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class SellItemStruct
    {
        
        private long itemIdField;
        
        private string itemTitleField;
        
        private string itemThumbnailUrlField;
        
        private ItemPriceStruct[] itemPriceField;
        
        private int itemStartQuantityField;
        
        private int itemSoldQuantityField;
        
        private int itemQuantityTypeField;
        
        private long itemStartTimeField;
        
        private long itemEndTimeField;
        
        private string itemEndTimeLeftField;
        
        private int itemBiddersCounterField;
        
        private UserInfoStruct itemHighestBidderField;
        
        private int itemCategoryIdField;
        
        private int itemWatchersCounterField;
        
        private int itemViewsCounterField;
        
        private string itemNoteField;
        
        private int itemSpecialInfoField;
        
        private int itemShopInfoField;
        
        private long itemProductInfoField;
        
        private int itemPayuInfoField;
        
        private DurationInfoStruct itemDurationInfoField;
        
        /// <remarks/>
        public long itemId
        {
            get
            {
                return this.itemIdField;
            }
            set
            {
                this.itemIdField = value;
            }
        }
        
        /// <remarks/>
        public string itemTitle
        {
            get
            {
                return this.itemTitleField;
            }
            set
            {
                this.itemTitleField = value;
            }
        }
        
        /// <remarks/>
        public string itemThumbnailUrl
        {
            get
            {
                return this.itemThumbnailUrlField;
            }
            set
            {
                this.itemThumbnailUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public ItemPriceStruct[] itemPrice
        {
            get
            {
                return this.itemPriceField;
            }
            set
            {
                this.itemPriceField = value;
            }
        }
        
        /// <remarks/>
        public int itemStartQuantity
        {
            get
            {
                return this.itemStartQuantityField;
            }
            set
            {
                this.itemStartQuantityField = value;
            }
        }
        
        /// <remarks/>
        public int itemSoldQuantity
        {
            get
            {
                return this.itemSoldQuantityField;
            }
            set
            {
                this.itemSoldQuantityField = value;
            }
        }
        
        /// <remarks/>
        public int itemQuantityType
        {
            get
            {
                return this.itemQuantityTypeField;
            }
            set
            {
                this.itemQuantityTypeField = value;
            }
        }
        
        /// <remarks/>
        public long itemStartTime
        {
            get
            {
                return this.itemStartTimeField;
            }
            set
            {
                this.itemStartTimeField = value;
            }
        }
        
        /// <remarks/>
        public long itemEndTime
        {
            get
            {
                return this.itemEndTimeField;
            }
            set
            {
                this.itemEndTimeField = value;
            }
        }
        
        /// <remarks/>
        public string itemEndTimeLeft
        {
            get
            {
                return this.itemEndTimeLeftField;
            }
            set
            {
                this.itemEndTimeLeftField = value;
            }
        }
        
        /// <remarks/>
        public int itemBiddersCounter
        {
            get
            {
                return this.itemBiddersCounterField;
            }
            set
            {
                this.itemBiddersCounterField = value;
            }
        }
        
        /// <remarks/>
        public UserInfoStruct itemHighestBidder
        {
            get
            {
                return this.itemHighestBidderField;
            }
            set
            {
                this.itemHighestBidderField = value;
            }
        }
        
        /// <remarks/>
        public int itemCategoryId
        {
            get
            {
                return this.itemCategoryIdField;
            }
            set
            {
                this.itemCategoryIdField = value;
            }
        }
        
        /// <remarks/>
        public int itemWatchersCounter
        {
            get
            {
                return this.itemWatchersCounterField;
            }
            set
            {
                this.itemWatchersCounterField = value;
            }
        }
        
        /// <remarks/>
        public int itemViewsCounter
        {
            get
            {
                return this.itemViewsCounterField;
            }
            set
            {
                this.itemViewsCounterField = value;
            }
        }
        
        /// <remarks/>
        public string itemNote
        {
            get
            {
                return this.itemNoteField;
            }
            set
            {
                this.itemNoteField = value;
            }
        }
        
        /// <remarks/>
        public int itemSpecialInfo
        {
            get
            {
                return this.itemSpecialInfoField;
            }
            set
            {
                this.itemSpecialInfoField = value;
            }
        }
        
        /// <remarks/>
        public int itemShopInfo
        {
            get
            {
                return this.itemShopInfoField;
            }
            set
            {
                this.itemShopInfoField = value;
            }
        }
        
        /// <remarks/>
        public long itemProductInfo
        {
            get
            {
                return this.itemProductInfoField;
            }
            set
            {
                this.itemProductInfoField = value;
            }
        }
        
        /// <remarks/>
        public int itemPayuInfo
        {
            get
            {
                return this.itemPayuInfoField;
            }
            set
            {
                this.itemPayuInfoField = value;
            }
        }
        
        /// <remarks/>
        public DurationInfoStruct itemDurationInfo
        {
            get
            {
                return this.itemDurationInfoField;
            }
            set
            {
                this.itemDurationInfoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class SellFilterOptionsStruct
    {
        
        private int filterFormatField;
        
        private bool filterFormatFieldSpecified;
        
        private int filterBidsField;
        
        private bool filterBidsFieldSpecified;
        
        private int filterToEndField;
        
        private bool filterToEndFieldSpecified;
        
        private int filterFromStartField;
        
        private bool filterFromStartFieldSpecified;
        
        private int filterAutoListingField;
        
        private bool filterAutoListingFieldSpecified;
        
        private FilterPriceStruct filterPriceField;
        
        private int filterDurationTypeField;
        
        private bool filterDurationTypeFieldSpecified;
        
        /// <remarks/>
        public int filterFormat
        {
            get
            {
                return this.filterFormatField;
            }
            set
            {
                this.filterFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool filterFormatSpecified
        {
            get
            {
                return this.filterFormatFieldSpecified;
            }
            set
            {
                this.filterFormatFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int filterBids
        {
            get
            {
                return this.filterBidsField;
            }
            set
            {
                this.filterBidsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool filterBidsSpecified
        {
            get
            {
                return this.filterBidsFieldSpecified;
            }
            set
            {
                this.filterBidsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int filterToEnd
        {
            get
            {
                return this.filterToEndField;
            }
            set
            {
                this.filterToEndField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool filterToEndSpecified
        {
            get
            {
                return this.filterToEndFieldSpecified;
            }
            set
            {
                this.filterToEndFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int filterFromStart
        {
            get
            {
                return this.filterFromStartField;
            }
            set
            {
                this.filterFromStartField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool filterFromStartSpecified
        {
            get
            {
                return this.filterFromStartFieldSpecified;
            }
            set
            {
                this.filterFromStartFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int filterAutoListing
        {
            get
            {
                return this.filterAutoListingField;
            }
            set
            {
                this.filterAutoListingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool filterAutoListingSpecified
        {
            get
            {
                return this.filterAutoListingFieldSpecified;
            }
            set
            {
                this.filterAutoListingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public FilterPriceStruct filterPrice
        {
            get
            {
                return this.filterPriceField;
            }
            set
            {
                this.filterPriceField = value;
            }
        }
        
        /// <remarks/>
        public int filterDurationType
        {
            get
            {
                return this.filterDurationTypeField;
            }
            set
            {
                this.filterDurationTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool filterDurationTypeSpecified
        {
            get
            {
                return this.filterDurationTypeFieldSpecified;
            }
            set
            {
                this.filterDurationTypeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PayoutRefundToStruct
    {
        
        private long tranasctionIdField;
        
        private long refundIdField;
        
        private string refundReasonField;
        
        private long itemIdField;
        
        private long toUserIdField;
        
        private float amountField;
        
        private string paidDateField;
        
        /// <remarks/>
        public long tranasctionId
        {
            get
            {
                return this.tranasctionIdField;
            }
            set
            {
                this.tranasctionIdField = value;
            }
        }
        
        /// <remarks/>
        public long refundId
        {
            get
            {
                return this.refundIdField;
            }
            set
            {
                this.refundIdField = value;
            }
        }
        
        /// <remarks/>
        public string refundReason
        {
            get
            {
                return this.refundReasonField;
            }
            set
            {
                this.refundReasonField = value;
            }
        }
        
        /// <remarks/>
        public long itemId
        {
            get
            {
                return this.itemIdField;
            }
            set
            {
                this.itemIdField = value;
            }
        }
        
        /// <remarks/>
        public long toUserId
        {
            get
            {
                return this.toUserIdField;
            }
            set
            {
                this.toUserIdField = value;
            }
        }
        
        /// <remarks/>
        public float amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        public string paidDate
        {
            get
            {
                return this.paidDateField;
            }
            set
            {
                this.paidDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PayoutRefundFromStruct
    {
        
        private long tranasctionIdField;
        
        private long refundIdField;
        
        private string refundReasonField;
        
        private long itemIdField;
        
        private long fromUserIdField;
        
        private float amountField;
        
        private string paidDateField;
        
        /// <remarks/>
        public long tranasctionId
        {
            get
            {
                return this.tranasctionIdField;
            }
            set
            {
                this.tranasctionIdField = value;
            }
        }
        
        /// <remarks/>
        public long refundId
        {
            get
            {
                return this.refundIdField;
            }
            set
            {
                this.refundIdField = value;
            }
        }
        
        /// <remarks/>
        public string refundReason
        {
            get
            {
                return this.refundReasonField;
            }
            set
            {
                this.refundReasonField = value;
            }
        }
        
        /// <remarks/>
        public long itemId
        {
            get
            {
                return this.itemIdField;
            }
            set
            {
                this.itemIdField = value;
            }
        }
        
        /// <remarks/>
        public long fromUserId
        {
            get
            {
                return this.fromUserIdField;
            }
            set
            {
                this.fromUserIdField = value;
            }
        }
        
        /// <remarks/>
        public float amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        public string paidDate
        {
            get
            {
                return this.paidDateField;
            }
            set
            {
                this.paidDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PayoutPaymentsStruct
    {
        
        private long tranasctionIdField;
        
        private string userNameField;
        
        private long userIdField;
        
        private float amountField;
        
        private float transportAmountField;
        
        private float totalAmountField;
        
        private string paidDateField;
        
        /// <remarks/>
        public long tranasctionId
        {
            get
            {
                return this.tranasctionIdField;
            }
            set
            {
                this.tranasctionIdField = value;
            }
        }
        
        /// <remarks/>
        public string userName
        {
            get
            {
                return this.userNameField;
            }
            set
            {
                this.userNameField = value;
            }
        }
        
        /// <remarks/>
        public long userId
        {
            get
            {
                return this.userIdField;
            }
            set
            {
                this.userIdField = value;
            }
        }
        
        /// <remarks/>
        public float amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        public float transportAmount
        {
            get
            {
                return this.transportAmountField;
            }
            set
            {
                this.transportAmountField = value;
            }
        }
        
        /// <remarks/>
        public float totalAmount
        {
            get
            {
                return this.totalAmountField;
            }
            set
            {
                this.totalAmountField = value;
            }
        }
        
        /// <remarks/>
        public string paidDate
        {
            get
            {
                return this.paidDateField;
            }
            set
            {
                this.paidDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class UserPayoutStruct
    {
        
        private long payTransIdField;
        
        private string payTransStatusField;
        
        private float payTransAmountField;
        
        private long payTransCreateDateField;
        
        private long payTransRecvDateField;
        
        private long payTransCancelDateField;
        
        private string payTransReportField;
        
        /// <remarks/>
        public long payTransId
        {
            get
            {
                return this.payTransIdField;
            }
            set
            {
                this.payTransIdField = value;
            }
        }
        
        /// <remarks/>
        public string payTransStatus
        {
            get
            {
                return this.payTransStatusField;
            }
            set
            {
                this.payTransStatusField = value;
            }
        }
        
        /// <remarks/>
        public float payTransAmount
        {
            get
            {
                return this.payTransAmountField;
            }
            set
            {
                this.payTransAmountField = value;
            }
        }
        
        /// <remarks/>
        public long payTransCreateDate
        {
            get
            {
                return this.payTransCreateDateField;
            }
            set
            {
                this.payTransCreateDateField = value;
            }
        }
        
        /// <remarks/>
        public long payTransRecvDate
        {
            get
            {
                return this.payTransRecvDateField;
            }
            set
            {
                this.payTransRecvDateField = value;
            }
        }
        
        /// <remarks/>
        public long payTransCancelDate
        {
            get
            {
                return this.payTransCancelDateField;
            }
            set
            {
                this.payTransCancelDateField = value;
            }
        }
        
        /// <remarks/>
        public string payTransReport
        {
            get
            {
                return this.payTransReportField;
            }
            set
            {
                this.payTransReportField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class UserPaymentRefundsStruct
    {
        
        private long payRefundTransIdField;
        
        private long payRefundItIdField;
        
        private int payRefundSellerIdField;
        
        private float payRefundValueField;
        
        private string payRefundReasonField;
        
        private long payRefundDateField;
        
        /// <remarks/>
        public long payRefundTransId
        {
            get
            {
                return this.payRefundTransIdField;
            }
            set
            {
                this.payRefundTransIdField = value;
            }
        }
        
        /// <remarks/>
        public long payRefundItId
        {
            get
            {
                return this.payRefundItIdField;
            }
            set
            {
                this.payRefundItIdField = value;
            }
        }
        
        /// <remarks/>
        public int payRefundSellerId
        {
            get
            {
                return this.payRefundSellerIdField;
            }
            set
            {
                this.payRefundSellerIdField = value;
            }
        }
        
        /// <remarks/>
        public float payRefundValue
        {
            get
            {
                return this.payRefundValueField;
            }
            set
            {
                this.payRefundValueField = value;
            }
        }
        
        /// <remarks/>
        public string payRefundReason
        {
            get
            {
                return this.payRefundReasonField;
            }
            set
            {
                this.payRefundReasonField = value;
            }
        }
        
        /// <remarks/>
        public long payRefundDate
        {
            get
            {
                return this.payRefundDateField;
            }
            set
            {
                this.payRefundDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PayoutAutoFrequencyStruct
    {
        
        private short frequencyTypeField;
        
        private short frequencyWeekValueField;
        
        private short frequencyMonthValueField;
        
        /// <remarks/>
        public short frequencyType
        {
            get
            {
                return this.frequencyTypeField;
            }
            set
            {
                this.frequencyTypeField = value;
            }
        }
        
        /// <remarks/>
        public short frequencyWeekValue
        {
            get
            {
                return this.frequencyWeekValueField;
            }
            set
            {
                this.frequencyWeekValueField = value;
            }
        }
        
        /// <remarks/>
        public short frequencyMonthValue
        {
            get
            {
                return this.frequencyMonthValueField;
            }
            set
            {
                this.frequencyMonthValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PayoutAutoSettingsStruct
    {
        
        private float payoutAutoAmountField;
        
        private PayoutAutoFrequencyStruct payoutAutoFrequencyField;
        
        /// <remarks/>
        public float payoutAutoAmount
        {
            get
            {
                return this.payoutAutoAmountField;
            }
            set
            {
                this.payoutAutoAmountField = value;
            }
        }
        
        /// <remarks/>
        public PayoutAutoFrequencyStruct payoutAutoFrequency
        {
            get
            {
                return this.payoutAutoFrequencyField;
            }
            set
            {
                this.payoutAutoFrequencyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PaymentsPayoutStruct
    {
        
        private int payoutTypeField;
        
        private PayoutAutoSettingsStruct payoutAutoSettingsField;
        
        /// <remarks/>
        public int payoutType
        {
            get
            {
                return this.payoutTypeField;
            }
            set
            {
                this.payoutTypeField = value;
            }
        }
        
        /// <remarks/>
        public PayoutAutoSettingsStruct payoutAutoSettings
        {
            get
            {
                return this.payoutAutoSettingsField;
            }
            set
            {
                this.payoutAutoSettingsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PaymentsUserDataStruct
    {
        
        private string userFullNameField;
        
        private string userAddressField;
        
        private string userPostcodeField;
        
        private string userCityField;
        
        private int userCountryField;
        
        private string userPhoneField;
        
        /// <remarks/>
        public string userFullName
        {
            get
            {
                return this.userFullNameField;
            }
            set
            {
                this.userFullNameField = value;
            }
        }
        
        /// <remarks/>
        public string userAddress
        {
            get
            {
                return this.userAddressField;
            }
            set
            {
                this.userAddressField = value;
            }
        }
        
        /// <remarks/>
        public string userPostcode
        {
            get
            {
                return this.userPostcodeField;
            }
            set
            {
                this.userPostcodeField = value;
            }
        }
        
        /// <remarks/>
        public string userCity
        {
            get
            {
                return this.userCityField;
            }
            set
            {
                this.userCityField = value;
            }
        }
        
        /// <remarks/>
        public int userCountry
        {
            get
            {
                return this.userCountryField;
            }
            set
            {
                this.userCountryField = value;
            }
        }
        
        /// <remarks/>
        public string userPhone
        {
            get
            {
                return this.userPhoneField;
            }
            set
            {
                this.userPhoneField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PaymentsInfoStruct
    {
        
        private float paymentsBalanceField;
        
        private string paymentsBankAccountField;
        
        private PaymentsUserDataStruct paymentsUserDataField;
        
        private PaymentsPayoutStruct paymentsPayoutField;
        
        private int paymentsNotificationsField;
        
        /// <remarks/>
        public float paymentsBalance
        {
            get
            {
                return this.paymentsBalanceField;
            }
            set
            {
                this.paymentsBalanceField = value;
            }
        }
        
        /// <remarks/>
        public string paymentsBankAccount
        {
            get
            {
                return this.paymentsBankAccountField;
            }
            set
            {
                this.paymentsBankAccountField = value;
            }
        }
        
        /// <remarks/>
        public PaymentsUserDataStruct paymentsUserData
        {
            get
            {
                return this.paymentsUserDataField;
            }
            set
            {
                this.paymentsUserDataField = value;
            }
        }
        
        /// <remarks/>
        public PaymentsPayoutStruct paymentsPayout
        {
            get
            {
                return this.paymentsPayoutField;
            }
            set
            {
                this.paymentsPayoutField = value;
            }
        }
        
        /// <remarks/>
        public int paymentsNotifications
        {
            get
            {
                return this.paymentsNotificationsField;
            }
            set
            {
                this.paymentsNotificationsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PaymentItemsStruct
    {
        
        private long payTransItIdField;
        
        private string payTransItNameField;
        
        private int payTransItCountField;
        
        private float payTransItPriceField;
        
        /// <remarks/>
        public long payTransItId
        {
            get
            {
                return this.payTransItIdField;
            }
            set
            {
                this.payTransItIdField = value;
            }
        }
        
        /// <remarks/>
        public string payTransItName
        {
            get
            {
                return this.payTransItNameField;
            }
            set
            {
                this.payTransItNameField = value;
            }
        }
        
        /// <remarks/>
        public int payTransItCount
        {
            get
            {
                return this.payTransItCountField;
            }
            set
            {
                this.payTransItCountField = value;
            }
        }
        
        /// <remarks/>
        public float payTransItPrice
        {
            get
            {
                return this.payTransItPriceField;
            }
            set
            {
                this.payTransItPriceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PaymentSellersStruct
    {
        
        private int payTransSellerIdField;
        
        private string payTransSellerNameField;
        
        private PaymentItemsStruct[] payTransItemsField;
        
        private float payTransSellerPostageAmountField;
        
        /// <remarks/>
        public int payTransSellerId
        {
            get
            {
                return this.payTransSellerIdField;
            }
            set
            {
                this.payTransSellerIdField = value;
            }
        }
        
        /// <remarks/>
        public string payTransSellerName
        {
            get
            {
                return this.payTransSellerNameField;
            }
            set
            {
                this.payTransSellerNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public PaymentItemsStruct[] payTransItems
        {
            get
            {
                return this.payTransItemsField;
            }
            set
            {
                this.payTransItemsField = value;
            }
        }
        
        /// <remarks/>
        public float payTransSellerPostageAmount
        {
            get
            {
                return this.payTransSellerPostageAmountField;
            }
            set
            {
                this.payTransSellerPostageAmountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class UserPaymentStruct
    {
        
        private long payTransIdField;
        
        private PaymentSellersStruct[] payTransSellersField;
        
        private string payTransTypeField;
        
        private string payTransStatusField;
        
        private float payTransAmountField;
        
        private long payTransCreateDateField;
        
        private float payTransPriceField;
        
        private float payTransPostageAmountField;
        
        private int payTransIncompleteField;
        
        /// <remarks/>
        public long payTransId
        {
            get
            {
                return this.payTransIdField;
            }
            set
            {
                this.payTransIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public PaymentSellersStruct[] payTransSellers
        {
            get
            {
                return this.payTransSellersField;
            }
            set
            {
                this.payTransSellersField = value;
            }
        }
        
        /// <remarks/>
        public string payTransType
        {
            get
            {
                return this.payTransTypeField;
            }
            set
            {
                this.payTransTypeField = value;
            }
        }
        
        /// <remarks/>
        public string payTransStatus
        {
            get
            {
                return this.payTransStatusField;
            }
            set
            {
                this.payTransStatusField = value;
            }
        }
        
        /// <remarks/>
        public float payTransAmount
        {
            get
            {
                return this.payTransAmountField;
            }
            set
            {
                this.payTransAmountField = value;
            }
        }
        
        /// <remarks/>
        public long payTransCreateDate
        {
            get
            {
                return this.payTransCreateDateField;
            }
            set
            {
                this.payTransCreateDateField = value;
            }
        }
        
        /// <remarks/>
        public float payTransPrice
        {
            get
            {
                return this.payTransPriceField;
            }
            set
            {
                this.payTransPriceField = value;
            }
        }
        
        /// <remarks/>
        public float payTransPostageAmount
        {
            get
            {
                return this.payTransPostageAmountField;
            }
            set
            {
                this.payTransPostageAmountField = value;
            }
        }
        
        /// <remarks/>
        public int payTransIncomplete
        {
            get
            {
                return this.payTransIncompleteField;
            }
            set
            {
                this.payTransIncompleteField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class NotWonItemStruct
    {
        
        private long itemIdField;
        
        private string itemTitleField;
        
        private string itemThumbnailUrlField;
        
        private ItemPriceStruct[] itemPriceField;
        
        private int itemLeftQuantityField;
        
        private int itemQuantityTypeField;
        
        private long itemEndTimeField;
        
        private string itemEndTimeLeftField;
        
        private UserInfoStruct itemSellerField;
        
        private int itemBiddersCounterField;
        
        private UserInfoStruct itemHighestBidderField;
        
        private int itemCategoryIdField;
        
        private int itemViewsCounterField;
        
        private string itemNoteField;
        
        private int itemSpecialInfoField;
        
        private int itemShopInfoField;
        
        private long itemProductInfoField;
        
        private int itemPayuInfoField;
        
        /// <remarks/>
        public long itemId
        {
            get
            {
                return this.itemIdField;
            }
            set
            {
                this.itemIdField = value;
            }
        }
        
        /// <remarks/>
        public string itemTitle
        {
            get
            {
                return this.itemTitleField;
            }
            set
            {
                this.itemTitleField = value;
            }
        }
        
        /// <remarks/>
        public string itemThumbnailUrl
        {
            get
            {
                return this.itemThumbnailUrlField;
            }
            set
            {
                this.itemThumbnailUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public ItemPriceStruct[] itemPrice
        {
            get
            {
                return this.itemPriceField;
            }
            set
            {
                this.itemPriceField = value;
            }
        }
        
        /// <remarks/>
        public int itemLeftQuantity
        {
            get
            {
                return this.itemLeftQuantityField;
            }
            set
            {
                this.itemLeftQuantityField = value;
            }
        }
        
        /// <remarks/>
        public int itemQuantityType
        {
            get
            {
                return this.itemQuantityTypeField;
            }
            set
            {
                this.itemQuantityTypeField = value;
            }
        }
        
        /// <remarks/>
        public long itemEndTime
        {
            get
            {
                return this.itemEndTimeField;
            }
            set
            {
                this.itemEndTimeField = value;
            }
        }
        
        /// <remarks/>
        public string itemEndTimeLeft
        {
            get
            {
                return this.itemEndTimeLeftField;
            }
            set
            {
                this.itemEndTimeLeftField = value;
            }
        }
        
        /// <remarks/>
        public UserInfoStruct itemSeller
        {
            get
            {
                return this.itemSellerField;
            }
            set
            {
                this.itemSellerField = value;
            }
        }
        
        /// <remarks/>
        public int itemBiddersCounter
        {
            get
            {
                return this.itemBiddersCounterField;
            }
            set
            {
                this.itemBiddersCounterField = value;
            }
        }
        
        /// <remarks/>
        public UserInfoStruct itemHighestBidder
        {
            get
            {
                return this.itemHighestBidderField;
            }
            set
            {
                this.itemHighestBidderField = value;
            }
        }
        
        /// <remarks/>
        public int itemCategoryId
        {
            get
            {
                return this.itemCategoryIdField;
            }
            set
            {
                this.itemCategoryIdField = value;
            }
        }
        
        /// <remarks/>
        public int itemViewsCounter
        {
            get
            {
                return this.itemViewsCounterField;
            }
            set
            {
                this.itemViewsCounterField = value;
            }
        }
        
        /// <remarks/>
        public string itemNote
        {
            get
            {
                return this.itemNoteField;
            }
            set
            {
                this.itemNoteField = value;
            }
        }
        
        /// <remarks/>
        public int itemSpecialInfo
        {
            get
            {
                return this.itemSpecialInfoField;
            }
            set
            {
                this.itemSpecialInfoField = value;
            }
        }
        
        /// <remarks/>
        public int itemShopInfo
        {
            get
            {
                return this.itemShopInfoField;
            }
            set
            {
                this.itemShopInfoField = value;
            }
        }
        
        /// <remarks/>
        public long itemProductInfo
        {
            get
            {
                return this.itemProductInfoField;
            }
            set
            {
                this.itemProductInfoField = value;
            }
        }
        
        /// <remarks/>
        public int itemPayuInfo
        {
            get
            {
                return this.itemPayuInfoField;
            }
            set
            {
                this.itemPayuInfoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class NotSoldItemStruct
    {
        
        private long itemIdField;
        
        private string itemTitleField;
        
        private string itemThumbnailUrlField;
        
        private ItemPriceStruct[] itemPriceField;
        
        private int itemStartQuantityField;
        
        private int itemQuantityTypeField;
        
        private long itemStartTimeField;
        
        private long itemEndTimeField;
        
        private int itemBiddersCounterField;
        
        private UserInfoStruct itemHighestBidderField;
        
        private int itemCategoryIdField;
        
        private int itemWatchersCounterField;
        
        private int itemViewsCounterField;
        
        private string itemNoteField;
        
        private int itemSpecialInfoField;
        
        private int itemShopInfoField;
        
        private long itemProductInfoField;
        
        private int itemPayuInfoField;
        
        /// <remarks/>
        public long itemId
        {
            get
            {
                return this.itemIdField;
            }
            set
            {
                this.itemIdField = value;
            }
        }
        
        /// <remarks/>
        public string itemTitle
        {
            get
            {
                return this.itemTitleField;
            }
            set
            {
                this.itemTitleField = value;
            }
        }
        
        /// <remarks/>
        public string itemThumbnailUrl
        {
            get
            {
                return this.itemThumbnailUrlField;
            }
            set
            {
                this.itemThumbnailUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public ItemPriceStruct[] itemPrice
        {
            get
            {
                return this.itemPriceField;
            }
            set
            {
                this.itemPriceField = value;
            }
        }
        
        /// <remarks/>
        public int itemStartQuantity
        {
            get
            {
                return this.itemStartQuantityField;
            }
            set
            {
                this.itemStartQuantityField = value;
            }
        }
        
        /// <remarks/>
        public int itemQuantityType
        {
            get
            {
                return this.itemQuantityTypeField;
            }
            set
            {
                this.itemQuantityTypeField = value;
            }
        }
        
        /// <remarks/>
        public long itemStartTime
        {
            get
            {
                return this.itemStartTimeField;
            }
            set
            {
                this.itemStartTimeField = value;
            }
        }
        
        /// <remarks/>
        public long itemEndTime
        {
            get
            {
                return this.itemEndTimeField;
            }
            set
            {
                this.itemEndTimeField = value;
            }
        }
        
        /// <remarks/>
        public int itemBiddersCounter
        {
            get
            {
                return this.itemBiddersCounterField;
            }
            set
            {
                this.itemBiddersCounterField = value;
            }
        }
        
        /// <remarks/>
        public UserInfoStruct itemHighestBidder
        {
            get
            {
                return this.itemHighestBidderField;
            }
            set
            {
                this.itemHighestBidderField = value;
            }
        }
        
        /// <remarks/>
        public int itemCategoryId
        {
            get
            {
                return this.itemCategoryIdField;
            }
            set
            {
                this.itemCategoryIdField = value;
            }
        }
        
        /// <remarks/>
        public int itemWatchersCounter
        {
            get
            {
                return this.itemWatchersCounterField;
            }
            set
            {
                this.itemWatchersCounterField = value;
            }
        }
        
        /// <remarks/>
        public int itemViewsCounter
        {
            get
            {
                return this.itemViewsCounterField;
            }
            set
            {
                this.itemViewsCounterField = value;
            }
        }
        
        /// <remarks/>
        public string itemNote
        {
            get
            {
                return this.itemNoteField;
            }
            set
            {
                this.itemNoteField = value;
            }
        }
        
        /// <remarks/>
        public int itemSpecialInfo
        {
            get
            {
                return this.itemSpecialInfoField;
            }
            set
            {
                this.itemSpecialInfoField = value;
            }
        }
        
        /// <remarks/>
        public int itemShopInfo
        {
            get
            {
                return this.itemShopInfoField;
            }
            set
            {
                this.itemShopInfoField = value;
            }
        }
        
        /// <remarks/>
        public long itemProductInfo
        {
            get
            {
                return this.itemProductInfoField;
            }
            set
            {
                this.itemProductInfoField = value;
            }
        }
        
        /// <remarks/>
        public int itemPayuInfo
        {
            get
            {
                return this.itemPayuInfoField;
            }
            set
            {
                this.itemPayuInfoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class NotSoldFilterOptionsStruct
    {
        
        private int filterFormatField;
        
        private bool filterFormatFieldSpecified;
        
        private int filterFromEndField;
        
        private bool filterFromEndFieldSpecified;
        
        private int filterAutoListingField;
        
        private bool filterAutoListingFieldSpecified;
        
        private FilterPriceStruct filterPriceField;
        
        private int filterDurationTypeField;
        
        private bool filterDurationTypeFieldSpecified;
        
        /// <remarks/>
        public int filterFormat
        {
            get
            {
                return this.filterFormatField;
            }
            set
            {
                this.filterFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool filterFormatSpecified
        {
            get
            {
                return this.filterFormatFieldSpecified;
            }
            set
            {
                this.filterFormatFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int filterFromEnd
        {
            get
            {
                return this.filterFromEndField;
            }
            set
            {
                this.filterFromEndField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool filterFromEndSpecified
        {
            get
            {
                return this.filterFromEndFieldSpecified;
            }
            set
            {
                this.filterFromEndFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int filterAutoListing
        {
            get
            {
                return this.filterAutoListingField;
            }
            set
            {
                this.filterAutoListingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool filterAutoListingSpecified
        {
            get
            {
                return this.filterAutoListingFieldSpecified;
            }
            set
            {
                this.filterAutoListingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public FilterPriceStruct filterPrice
        {
            get
            {
                return this.filterPriceField;
            }
            set
            {
                this.filterPriceField = value;
            }
        }
        
        /// <remarks/>
        public int filterDurationType
        {
            get
            {
                return this.filterDurationTypeField;
            }
            set
            {
                this.filterDurationTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool filterDurationTypeSpecified
        {
            get
            {
                return this.filterDurationTypeFieldSpecified;
            }
            set
            {
                this.filterDurationTypeFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class UserIncomingPaymentRefundsStruct
    {
        
        private long payRefundTransIdField;
        
        private long payRefundItIdField;
        
        private int payRefundBuyerIdField;
        
        private float payRefundValueField;
        
        private string payRefundReasonField;
        
        private long payRefundDateField;
        
        /// <remarks/>
        public long payRefundTransId
        {
            get
            {
                return this.payRefundTransIdField;
            }
            set
            {
                this.payRefundTransIdField = value;
            }
        }
        
        /// <remarks/>
        public long payRefundItId
        {
            get
            {
                return this.payRefundItIdField;
            }
            set
            {
                this.payRefundItIdField = value;
            }
        }
        
        /// <remarks/>
        public int payRefundBuyerId
        {
            get
            {
                return this.payRefundBuyerIdField;
            }
            set
            {
                this.payRefundBuyerIdField = value;
            }
        }
        
        /// <remarks/>
        public float payRefundValue
        {
            get
            {
                return this.payRefundValueField;
            }
            set
            {
                this.payRefundValueField = value;
            }
        }
        
        /// <remarks/>
        public string payRefundReason
        {
            get
            {
                return this.payRefundReasonField;
            }
            set
            {
                this.payRefundReasonField = value;
            }
        }
        
        /// <remarks/>
        public long payRefundDate
        {
            get
            {
                return this.payRefundDateField;
            }
            set
            {
                this.payRefundDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PaymentDetailsStruct
    {
        
        private long payTransDetailsItIdField;
        
        private float payTransDetailsPriceField;
        
        private int payTransDetailsCountField;
        
        /// <remarks/>
        public long payTransDetailsItId
        {
            get
            {
                return this.payTransDetailsItIdField;
            }
            set
            {
                this.payTransDetailsItIdField = value;
            }
        }
        
        /// <remarks/>
        public float payTransDetailsPrice
        {
            get
            {
                return this.payTransDetailsPriceField;
            }
            set
            {
                this.payTransDetailsPriceField = value;
            }
        }
        
        /// <remarks/>
        public int payTransDetailsCount
        {
            get
            {
                return this.payTransDetailsCountField;
            }
            set
            {
                this.payTransDetailsCountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class UserIncomingPaymentStruct
    {
        
        private long payTransIdField;
        
        private long payTransItIdField;
        
        private int payTransBuyerIdField;
        
        private string payTransTypeField;
        
        private string payTransStatusField;
        
        private float payTransAmountField;
        
        private long payTransCreateDateField;
        
        private long payTransRecvDateField;
        
        private float payTransPriceField;
        
        private int payTransCountField;
        
        private float payTransPostageAmountField;
        
        private PaymentDetailsStruct[] payTransDetailsField;
        
        private int payTransIncompleteField;
        
        private long payTransMainIdField;
        
        /// <remarks/>
        public long payTransId
        {
            get
            {
                return this.payTransIdField;
            }
            set
            {
                this.payTransIdField = value;
            }
        }
        
        /// <remarks/>
        public long payTransItId
        {
            get
            {
                return this.payTransItIdField;
            }
            set
            {
                this.payTransItIdField = value;
            }
        }
        
        /// <remarks/>
        public int payTransBuyerId
        {
            get
            {
                return this.payTransBuyerIdField;
            }
            set
            {
                this.payTransBuyerIdField = value;
            }
        }
        
        /// <remarks/>
        public string payTransType
        {
            get
            {
                return this.payTransTypeField;
            }
            set
            {
                this.payTransTypeField = value;
            }
        }
        
        /// <remarks/>
        public string payTransStatus
        {
            get
            {
                return this.payTransStatusField;
            }
            set
            {
                this.payTransStatusField = value;
            }
        }
        
        /// <remarks/>
        public float payTransAmount
        {
            get
            {
                return this.payTransAmountField;
            }
            set
            {
                this.payTransAmountField = value;
            }
        }
        
        /// <remarks/>
        public long payTransCreateDate
        {
            get
            {
                return this.payTransCreateDateField;
            }
            set
            {
                this.payTransCreateDateField = value;
            }
        }
        
        /// <remarks/>
        public long payTransRecvDate
        {
            get
            {
                return this.payTransRecvDateField;
            }
            set
            {
                this.payTransRecvDateField = value;
            }
        }
        
        /// <remarks/>
        public float payTransPrice
        {
            get
            {
                return this.payTransPriceField;
            }
            set
            {
                this.payTransPriceField = value;
            }
        }
        
        /// <remarks/>
        public int payTransCount
        {
            get
            {
                return this.payTransCountField;
            }
            set
            {
                this.payTransCountField = value;
            }
        }
        
        /// <remarks/>
        public float payTransPostageAmount
        {
            get
            {
                return this.payTransPostageAmountField;
            }
            set
            {
                this.payTransPostageAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public PaymentDetailsStruct[] payTransDetails
        {
            get
            {
                return this.payTransDetailsField;
            }
            set
            {
                this.payTransDetailsField = value;
            }
        }
        
        /// <remarks/>
        public int payTransIncomplete
        {
            get
            {
                return this.payTransIncompleteField;
            }
            set
            {
                this.payTransIncompleteField = value;
            }
        }
        
        /// <remarks/>
        public long payTransMainId
        {
            get
            {
                return this.payTransMainIdField;
            }
            set
            {
                this.payTransMainIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class FutureItemStruct
    {
        
        private long itemIdField;
        
        private string itemTitleField;
        
        private string itemThumbnailUrlField;
        
        private ItemPriceStruct[] itemPriceField;
        
        private int itemStartQuantityField;
        
        private int itemQuantityTypeField;
        
        private long itemStartTimeField;
        
        private int itemCategoryIdField;
        
        private string itemNoteField;
        
        private int itemSpecialInfoField;
        
        private int itemShopInfoField;
        
        private long itemProductInfoField;
        
        private int itemPayuInfoField;
        
        private int itemStatusField;
        
        /// <remarks/>
        public long itemId
        {
            get
            {
                return this.itemIdField;
            }
            set
            {
                this.itemIdField = value;
            }
        }
        
        /// <remarks/>
        public string itemTitle
        {
            get
            {
                return this.itemTitleField;
            }
            set
            {
                this.itemTitleField = value;
            }
        }
        
        /// <remarks/>
        public string itemThumbnailUrl
        {
            get
            {
                return this.itemThumbnailUrlField;
            }
            set
            {
                this.itemThumbnailUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public ItemPriceStruct[] itemPrice
        {
            get
            {
                return this.itemPriceField;
            }
            set
            {
                this.itemPriceField = value;
            }
        }
        
        /// <remarks/>
        public int itemStartQuantity
        {
            get
            {
                return this.itemStartQuantityField;
            }
            set
            {
                this.itemStartQuantityField = value;
            }
        }
        
        /// <remarks/>
        public int itemQuantityType
        {
            get
            {
                return this.itemQuantityTypeField;
            }
            set
            {
                this.itemQuantityTypeField = value;
            }
        }
        
        /// <remarks/>
        public long itemStartTime
        {
            get
            {
                return this.itemStartTimeField;
            }
            set
            {
                this.itemStartTimeField = value;
            }
        }
        
        /// <remarks/>
        public int itemCategoryId
        {
            get
            {
                return this.itemCategoryIdField;
            }
            set
            {
                this.itemCategoryIdField = value;
            }
        }
        
        /// <remarks/>
        public string itemNote
        {
            get
            {
                return this.itemNoteField;
            }
            set
            {
                this.itemNoteField = value;
            }
        }
        
        /// <remarks/>
        public int itemSpecialInfo
        {
            get
            {
                return this.itemSpecialInfoField;
            }
            set
            {
                this.itemSpecialInfoField = value;
            }
        }
        
        /// <remarks/>
        public int itemShopInfo
        {
            get
            {
                return this.itemShopInfoField;
            }
            set
            {
                this.itemShopInfoField = value;
            }
        }
        
        /// <remarks/>
        public long itemProductInfo
        {
            get
            {
                return this.itemProductInfoField;
            }
            set
            {
                this.itemProductInfoField = value;
            }
        }
        
        /// <remarks/>
        public int itemPayuInfo
        {
            get
            {
                return this.itemPayuInfoField;
            }
            set
            {
                this.itemPayuInfoField = value;
            }
        }
        
        /// <remarks/>
        public int itemStatus
        {
            get
            {
                return this.itemStatusField;
            }
            set
            {
                this.itemStatusField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class FutureFilterOptionsStruct
    {
        
        private int filterFormatField;
        
        private bool filterFormatFieldSpecified;
        
        /// <remarks/>
        public int filterFormat
        {
            get
            {
                return this.filterFormatField;
            }
            set
            {
                this.filterFormatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool filterFormatSpecified
        {
            get
            {
                return this.filterFormatFieldSpecified;
            }
            set
            {
                this.filterFormatFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class RelatedPersonsStruct
    {
        
        private string spouseFirstNameField;
        
        private string spouseLastNameField;
        
        /// <remarks/>
        public string spouseFirstName
        {
            get
            {
                return this.spouseFirstNameField;
            }
            set
            {
                this.spouseFirstNameField = value;
            }
        }
        
        /// <remarks/>
        public string spouseLastName
        {
            get
            {
                return this.spouseLastNameField;
            }
            set
            {
                this.spouseLastNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class AlcoholDataStruct
    {
        
        private string alcoholOpeningDateField;
        
        private string alcoholExpirationDateField;
        
        private string alcoholShopNameField;
        
        private string alcoholShopAddressField;
        
        private string alcoholShopPostcodeField;
        
        private string alcoholShopCityField;
        
        private string alcoholShopCommuneField;
        
        private int alcoholShopCountryIdField;
        
        private int alcoholShopStateIdField;
        
        private string alcoholPermitNumberField;
        
        private string alcoholPermitAuthorityField;
        
        private string alcoholPermitInfoField;
        
        /// <remarks/>
        public string alcoholOpeningDate
        {
            get
            {
                return this.alcoholOpeningDateField;
            }
            set
            {
                this.alcoholOpeningDateField = value;
            }
        }
        
        /// <remarks/>
        public string alcoholExpirationDate
        {
            get
            {
                return this.alcoholExpirationDateField;
            }
            set
            {
                this.alcoholExpirationDateField = value;
            }
        }
        
        /// <remarks/>
        public string alcoholShopName
        {
            get
            {
                return this.alcoholShopNameField;
            }
            set
            {
                this.alcoholShopNameField = value;
            }
        }
        
        /// <remarks/>
        public string alcoholShopAddress
        {
            get
            {
                return this.alcoholShopAddressField;
            }
            set
            {
                this.alcoholShopAddressField = value;
            }
        }
        
        /// <remarks/>
        public string alcoholShopPostcode
        {
            get
            {
                return this.alcoholShopPostcodeField;
            }
            set
            {
                this.alcoholShopPostcodeField = value;
            }
        }
        
        /// <remarks/>
        public string alcoholShopCity
        {
            get
            {
                return this.alcoholShopCityField;
            }
            set
            {
                this.alcoholShopCityField = value;
            }
        }
        
        /// <remarks/>
        public string alcoholShopCommune
        {
            get
            {
                return this.alcoholShopCommuneField;
            }
            set
            {
                this.alcoholShopCommuneField = value;
            }
        }
        
        /// <remarks/>
        public int alcoholShopCountryId
        {
            get
            {
                return this.alcoholShopCountryIdField;
            }
            set
            {
                this.alcoholShopCountryIdField = value;
            }
        }
        
        /// <remarks/>
        public int alcoholShopStateId
        {
            get
            {
                return this.alcoholShopStateIdField;
            }
            set
            {
                this.alcoholShopStateIdField = value;
            }
        }
        
        /// <remarks/>
        public string alcoholPermitNumber
        {
            get
            {
                return this.alcoholPermitNumberField;
            }
            set
            {
                this.alcoholPermitNumberField = value;
            }
        }
        
        /// <remarks/>
        public string alcoholPermitAuthority
        {
            get
            {
                return this.alcoholPermitAuthorityField;
            }
            set
            {
                this.alcoholPermitAuthorityField = value;
            }
        }
        
        /// <remarks/>
        public string alcoholPermitInfo
        {
            get
            {
                return this.alcoholPermitInfoField;
            }
            set
            {
                this.alcoholPermitInfoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PharmacyDataStruct
    {
        
        private string pharmacyOpeningDateField;
        
        private string pharmacyExpirationDateField;
        
        private string pharmacyNameField;
        
        private string pharmacyPharmacistFullNameField;
        
        private string pharmacyAddressField;
        
        private string pharmacyPostcodeField;
        
        private string pharmacyCityField;
        
        private string pharmacyCommuneField;
        
        private int pharmacyCountryIdField;
        
        private int pharmacyStateIdField;
        
        private string pharmacyPermitNumberField;
        
        private string pharmacyPermitInfoField;
        
        /// <remarks/>
        public string pharmacyOpeningDate
        {
            get
            {
                return this.pharmacyOpeningDateField;
            }
            set
            {
                this.pharmacyOpeningDateField = value;
            }
        }
        
        /// <remarks/>
        public string pharmacyExpirationDate
        {
            get
            {
                return this.pharmacyExpirationDateField;
            }
            set
            {
                this.pharmacyExpirationDateField = value;
            }
        }
        
        /// <remarks/>
        public string pharmacyName
        {
            get
            {
                return this.pharmacyNameField;
            }
            set
            {
                this.pharmacyNameField = value;
            }
        }
        
        /// <remarks/>
        public string pharmacyPharmacistFullName
        {
            get
            {
                return this.pharmacyPharmacistFullNameField;
            }
            set
            {
                this.pharmacyPharmacistFullNameField = value;
            }
        }
        
        /// <remarks/>
        public string pharmacyAddress
        {
            get
            {
                return this.pharmacyAddressField;
            }
            set
            {
                this.pharmacyAddressField = value;
            }
        }
        
        /// <remarks/>
        public string pharmacyPostcode
        {
            get
            {
                return this.pharmacyPostcodeField;
            }
            set
            {
                this.pharmacyPostcodeField = value;
            }
        }
        
        /// <remarks/>
        public string pharmacyCity
        {
            get
            {
                return this.pharmacyCityField;
            }
            set
            {
                this.pharmacyCityField = value;
            }
        }
        
        /// <remarks/>
        public string pharmacyCommune
        {
            get
            {
                return this.pharmacyCommuneField;
            }
            set
            {
                this.pharmacyCommuneField = value;
            }
        }
        
        /// <remarks/>
        public int pharmacyCountryId
        {
            get
            {
                return this.pharmacyCountryIdField;
            }
            set
            {
                this.pharmacyCountryIdField = value;
            }
        }
        
        /// <remarks/>
        public int pharmacyStateId
        {
            get
            {
                return this.pharmacyStateIdField;
            }
            set
            {
                this.pharmacyStateIdField = value;
            }
        }
        
        /// <remarks/>
        public string pharmacyPermitNumber
        {
            get
            {
                return this.pharmacyPermitNumberField;
            }
            set
            {
                this.pharmacyPermitNumberField = value;
            }
        }
        
        /// <remarks/>
        public string pharmacyPermitInfo
        {
            get
            {
                return this.pharmacyPermitInfoField;
            }
            set
            {
                this.pharmacyPermitInfoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class CompanyExtraDataStruct
    {
        
        private string companyTypeField;
        
        private string companyNipField;
        
        private string companyRegonField;
        
        private string companyKrsField;
        
        private string companyActivitySortField;
        
        /// <remarks/>
        public string companyType
        {
            get
            {
                return this.companyTypeField;
            }
            set
            {
                this.companyTypeField = value;
            }
        }
        
        /// <remarks/>
        public string companyNip
        {
            get
            {
                return this.companyNipField;
            }
            set
            {
                this.companyNipField = value;
            }
        }
        
        /// <remarks/>
        public string companyRegon
        {
            get
            {
                return this.companyRegonField;
            }
            set
            {
                this.companyRegonField = value;
            }
        }
        
        /// <remarks/>
        public string companyKrs
        {
            get
            {
                return this.companyKrsField;
            }
            set
            {
                this.companyKrsField = value;
            }
        }
        
        /// <remarks/>
        public string companyActivitySort
        {
            get
            {
                return this.companyActivitySortField;
            }
            set
            {
                this.companyActivitySortField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class InvoiceDataStruct
    {
        
        private string companyNameField;
        
        private string companyNipField;
        
        /// <remarks/>
        public string companyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
            }
        }
        
        /// <remarks/>
        public string companyNip
        {
            get
            {
                return this.companyNipField;
            }
            set
            {
                this.companyNipField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class BidItemStruct
    {
        
        private long itemIdField;
        
        private string itemTitleField;
        
        private string itemThumbnailUrlField;
        
        private ItemPriceStruct[] itemPriceField;
        
        private int itemBidQuantityField;
        
        private int itemLeftQuantityField;
        
        private int itemQuantityTypeField;
        
        private long itemEndTimeField;
        
        private string itemEndTimeLeftField;
        
        private UserInfoStruct itemSellerField;
        
        private int itemBiddersCounterField;
        
        private UserInfoStruct itemHighestBidderField;
        
        private int itemCategoryIdField;
        
        private int itemViewsCounterField;
        
        private string itemNoteField;
        
        private int itemSpecialInfoField;
        
        private int itemShopInfoField;
        
        private long itemProductInfoField;
        
        private int itemPayuInfoField;
        
        /// <remarks/>
        public long itemId
        {
            get
            {
                return this.itemIdField;
            }
            set
            {
                this.itemIdField = value;
            }
        }
        
        /// <remarks/>
        public string itemTitle
        {
            get
            {
                return this.itemTitleField;
            }
            set
            {
                this.itemTitleField = value;
            }
        }
        
        /// <remarks/>
        public string itemThumbnailUrl
        {
            get
            {
                return this.itemThumbnailUrlField;
            }
            set
            {
                this.itemThumbnailUrlField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public ItemPriceStruct[] itemPrice
        {
            get
            {
                return this.itemPriceField;
            }
            set
            {
                this.itemPriceField = value;
            }
        }
        
        /// <remarks/>
        public int itemBidQuantity
        {
            get
            {
                return this.itemBidQuantityField;
            }
            set
            {
                this.itemBidQuantityField = value;
            }
        }
        
        /// <remarks/>
        public int itemLeftQuantity
        {
            get
            {
                return this.itemLeftQuantityField;
            }
            set
            {
                this.itemLeftQuantityField = value;
            }
        }
        
        /// <remarks/>
        public int itemQuantityType
        {
            get
            {
                return this.itemQuantityTypeField;
            }
            set
            {
                this.itemQuantityTypeField = value;
            }
        }
        
        /// <remarks/>
        public long itemEndTime
        {
            get
            {
                return this.itemEndTimeField;
            }
            set
            {
                this.itemEndTimeField = value;
            }
        }
        
        /// <remarks/>
        public string itemEndTimeLeft
        {
            get
            {
                return this.itemEndTimeLeftField;
            }
            set
            {
                this.itemEndTimeLeftField = value;
            }
        }
        
        /// <remarks/>
        public UserInfoStruct itemSeller
        {
            get
            {
                return this.itemSellerField;
            }
            set
            {
                this.itemSellerField = value;
            }
        }
        
        /// <remarks/>
        public int itemBiddersCounter
        {
            get
            {
                return this.itemBiddersCounterField;
            }
            set
            {
                this.itemBiddersCounterField = value;
            }
        }
        
        /// <remarks/>
        public UserInfoStruct itemHighestBidder
        {
            get
            {
                return this.itemHighestBidderField;
            }
            set
            {
                this.itemHighestBidderField = value;
            }
        }
        
        /// <remarks/>
        public int itemCategoryId
        {
            get
            {
                return this.itemCategoryIdField;
            }
            set
            {
                this.itemCategoryIdField = value;
            }
        }
        
        /// <remarks/>
        public int itemViewsCounter
        {
            get
            {
                return this.itemViewsCounterField;
            }
            set
            {
                this.itemViewsCounterField = value;
            }
        }
        
        /// <remarks/>
        public string itemNote
        {
            get
            {
                return this.itemNoteField;
            }
            set
            {
                this.itemNoteField = value;
            }
        }
        
        /// <remarks/>
        public int itemSpecialInfo
        {
            get
            {
                return this.itemSpecialInfoField;
            }
            set
            {
                this.itemSpecialInfoField = value;
            }
        }
        
        /// <remarks/>
        public int itemShopInfo
        {
            get
            {
                return this.itemShopInfoField;
            }
            set
            {
                this.itemShopInfoField = value;
            }
        }
        
        /// <remarks/>
        public long itemProductInfo
        {
            get
            {
                return this.itemProductInfoField;
            }
            set
            {
                this.itemProductInfoField = value;
            }
        }
        
        /// <remarks/>
        public int itemPayuInfo
        {
            get
            {
                return this.itemPayuInfoField;
            }
            set
            {
                this.itemPayuInfoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class SortOptionsStruct
    {
        
        private int sortTypeField;
        
        private bool sortTypeFieldSpecified;
        
        private int sortOrderField;
        
        private bool sortOrderFieldSpecified;
        
        /// <remarks/>
        public int sortType
        {
            get
            {
                return this.sortTypeField;
            }
            set
            {
                this.sortTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sortTypeSpecified
        {
            get
            {
                return this.sortTypeFieldSpecified;
            }
            set
            {
                this.sortTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int sortOrder
        {
            get
            {
                return this.sortOrderField;
            }
            set
            {
                this.sortOrderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool sortOrderSpecified
        {
            get
            {
                return this.sortOrderFieldSpecified;
            }
            set
            {
                this.sortOrderFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class AddressInfoStruct
    {
        
        private int addressTypeField;
        
        private AddressUserDataStruct addressUserDataField;
        
        /// <remarks/>
        public int addressType
        {
            get
            {
                return this.addressTypeField;
            }
            set
            {
                this.addressTypeField = value;
            }
        }
        
        /// <remarks/>
        public AddressUserDataStruct addressUserData
        {
            get
            {
                return this.addressUserDataField;
            }
            set
            {
                this.addressUserDataField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class MessageToBuyerStruct
    {
        
        private int messageSellerIdField;
        
        private string messageContentField;
        
        /// <remarks/>
        public int messageSellerId
        {
            get
            {
                return this.messageSellerIdField;
            }
            set
            {
                this.messageSellerIdField = value;
            }
        }
        
        /// <remarks/>
        public string messageContent
        {
            get
            {
                return this.messageContentField;
            }
            set
            {
                this.messageContentField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class FilterRelationType
    {
        
        private string[] relationAndField;
        
        private string[] relationOrField;
        
        private string[] relationExcludeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public string[] relationAnd
        {
            get
            {
                return this.relationAndField;
            }
            set
            {
                this.relationAndField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public string[] relationOr
        {
            get
            {
                return this.relationOrField;
            }
            set
            {
                this.relationOrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public string[] relationExclude
        {
            get
            {
                return this.relationExcludeField;
            }
            set
            {
                this.relationExcludeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class FilterValueType
    {
        
        private string filterValueIdField;
        
        private string filterValueNameField;
        
        private int filterValueCountField;
        
        private bool filterValueCountFieldSpecified;
        
        /// <remarks/>
        public string filterValueId
        {
            get
            {
                return this.filterValueIdField;
            }
            set
            {
                this.filterValueIdField = value;
            }
        }
        
        /// <remarks/>
        public string filterValueName
        {
            get
            {
                return this.filterValueNameField;
            }
            set
            {
                this.filterValueNameField = value;
            }
        }
        
        /// <remarks/>
        public int filterValueCount
        {
            get
            {
                return this.filterValueCountField;
            }
            set
            {
                this.filterValueCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool filterValueCountSpecified
        {
            get
            {
                return this.filterValueCountFieldSpecified;
            }
            set
            {
                this.filterValueCountFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class FiltersListType
    {
        
        private string filterIdField;
        
        private string filterNameField;
        
        private string filterTypeField;
        
        private string filterControlTypeField;
        
        private string filterDataTypeField;
        
        private bool filterIsRangeField;
        
        private int filterArraySizeField;
        
        private bool filterArraySizeFieldSpecified;
        
        private FilterValueType[] filterValuesField;
        
        private FilterRelationType filterRelationsField;
        
        /// <remarks/>
        public string filterId
        {
            get
            {
                return this.filterIdField;
            }
            set
            {
                this.filterIdField = value;
            }
        }
        
        /// <remarks/>
        public string filterName
        {
            get
            {
                return this.filterNameField;
            }
            set
            {
                this.filterNameField = value;
            }
        }
        
        /// <remarks/>
        public string filterType
        {
            get
            {
                return this.filterTypeField;
            }
            set
            {
                this.filterTypeField = value;
            }
        }
        
        /// <remarks/>
        public string filterControlType
        {
            get
            {
                return this.filterControlTypeField;
            }
            set
            {
                this.filterControlTypeField = value;
            }
        }
        
        /// <remarks/>
        public string filterDataType
        {
            get
            {
                return this.filterDataTypeField;
            }
            set
            {
                this.filterDataTypeField = value;
            }
        }
        
        /// <remarks/>
        public bool filterIsRange
        {
            get
            {
                return this.filterIsRangeField;
            }
            set
            {
                this.filterIsRangeField = value;
            }
        }
        
        /// <remarks/>
        public int filterArraySize
        {
            get
            {
                return this.filterArraySizeField;
            }
            set
            {
                this.filterArraySizeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool filterArraySizeSpecified
        {
            get
            {
                return this.filterArraySizeFieldSpecified;
            }
            set
            {
                this.filterArraySizeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public FilterValueType[] filterValues
        {
            get
            {
                return this.filterValuesField;
            }
            set
            {
                this.filterValuesField = value;
            }
        }
        
        /// <remarks/>
        public FilterRelationType filterRelations
        {
            get
            {
                return this.filterRelationsField;
            }
            set
            {
                this.filterRelationsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class CategoryPathType
    {
        
        private int categoryIdField;
        
        private string categoryNameField;
        
        private int categoryParentIdField;
        
        /// <remarks/>
        public int categoryId
        {
            get
            {
                return this.categoryIdField;
            }
            set
            {
                this.categoryIdField = value;
            }
        }
        
        /// <remarks/>
        public string categoryName
        {
            get
            {
                return this.categoryNameField;
            }
            set
            {
                this.categoryNameField = value;
            }
        }
        
        /// <remarks/>
        public int categoryParentId
        {
            get
            {
                return this.categoryParentIdField;
            }
            set
            {
                this.categoryParentIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class CategoryTreeType
    {
        
        private int categoryIdField;
        
        private string categoryNameField;
        
        private int categoryParentIdField;
        
        private int categoryItemsCountField;
        
        /// <remarks/>
        public int categoryId
        {
            get
            {
                return this.categoryIdField;
            }
            set
            {
                this.categoryIdField = value;
            }
        }
        
        /// <remarks/>
        public string categoryName
        {
            get
            {
                return this.categoryNameField;
            }
            set
            {
                this.categoryNameField = value;
            }
        }
        
        /// <remarks/>
        public int categoryParentId
        {
            get
            {
                return this.categoryParentIdField;
            }
            set
            {
                this.categoryParentIdField = value;
            }
        }
        
        /// <remarks/>
        public int categoryItemsCount
        {
            get
            {
                return this.categoryItemsCountField;
            }
            set
            {
                this.categoryItemsCountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class CategoriesListType
    {
        
        private CategoryTreeType[] categoriesTreeField;
        
        private CategoryPathType[] categoriesPathField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public CategoryTreeType[] categoriesTree
        {
            get
            {
                return this.categoriesTreeField;
            }
            set
            {
                this.categoriesTreeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public CategoryPathType[] categoriesPath
        {
            get
            {
                return this.categoriesPathField;
            }
            set
            {
                this.categoriesPathField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class AdvertInfoType
    {
        
        private string serviceIdField;
        
        private string advertIdField;
        
        /// <remarks/>
        public string serviceId
        {
            get
            {
                return this.serviceIdField;
            }
            set
            {
                this.serviceIdField = value;
            }
        }
        
        /// <remarks/>
        public string advertId
        {
            get
            {
                return this.advertIdField;
            }
            set
            {
                this.advertIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ParameterInfoType
    {
        
        private string parameterNameField;
        
        private string[] parameterValueField;
        
        private string parameterUnitField;
        
        private bool parameterIsRangeField;
        
        /// <remarks/>
        public string parameterName
        {
            get
            {
                return this.parameterNameField;
            }
            set
            {
                this.parameterNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public string[] parameterValue
        {
            get
            {
                return this.parameterValueField;
            }
            set
            {
                this.parameterValueField = value;
            }
        }
        
        /// <remarks/>
        public string parameterUnit
        {
            get
            {
                return this.parameterUnitField;
            }
            set
            {
                this.parameterUnitField = value;
            }
        }
        
        /// <remarks/>
        public bool parameterIsRange
        {
            get
            {
                return this.parameterIsRangeField;
            }
            set
            {
                this.parameterIsRangeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PhotoInfoType
    {
        
        private string photoSizeField;
        
        private string photoUrlField;
        
        private bool photoIsMainField;
        
        /// <remarks/>
        public string photoSize
        {
            get
            {
                return this.photoSizeField;
            }
            set
            {
                this.photoSizeField = value;
            }
        }
        
        /// <remarks/>
        public string photoUrl
        {
            get
            {
                return this.photoUrlField;
            }
            set
            {
                this.photoUrlField = value;
            }
        }
        
        /// <remarks/>
        public bool photoIsMain
        {
            get
            {
                return this.photoIsMainField;
            }
            set
            {
                this.photoIsMainField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PriceInfoType
    {
        
        private string priceTypeField;
        
        private float priceValueField;
        
        /// <remarks/>
        public string priceType
        {
            get
            {
                return this.priceTypeField;
            }
            set
            {
                this.priceTypeField = value;
            }
        }
        
        /// <remarks/>
        public float priceValue
        {
            get
            {
                return this.priceValueField;
            }
            set
            {
                this.priceValueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class UserInfoType
    {
        
        private int userIdField;
        
        private string userLoginField;
        
        private int userRatingField;
        
        private int userIconsField;
        
        private int countryIdField;
        
        /// <remarks/>
        public int userId
        {
            get
            {
                return this.userIdField;
            }
            set
            {
                this.userIdField = value;
            }
        }
        
        /// <remarks/>
        public string userLogin
        {
            get
            {
                return this.userLoginField;
            }
            set
            {
                this.userLoginField = value;
            }
        }
        
        /// <remarks/>
        public int userRating
        {
            get
            {
                return this.userRatingField;
            }
            set
            {
                this.userRatingField = value;
            }
        }
        
        /// <remarks/>
        public int userIcons
        {
            get
            {
                return this.userIconsField;
            }
            set
            {
                this.userIconsField = value;
            }
        }
        
        /// <remarks/>
        public int countryId
        {
            get
            {
                return this.countryIdField;
            }
            set
            {
                this.countryIdField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ItemsListType
    {
        
        private long itemIdField;
        
        private string itemTitleField;
        
        private int leftCountField;
        
        private int bidsCountField;
        
        private int biddersCountField;
        
        private string quantityTypeField;
        
        private System.DateTime endingTimeField;
        
        private bool endingTimeFieldSpecified;
        
        private string timeToEndField;
        
        private int categoryIdField;
        
        private string conditionInfoField;
        
        private int promotionInfoField;
        
        private int additionalInfoField;
        
        private UserInfoType sellerInfoField;
        
        private PriceInfoType[] priceInfoField;
        
        private PhotoInfoType[] photosInfoField;
        
        private ParameterInfoType[] parametersInfoField;
        
        private AdvertInfoType advertInfoField;
        
        /// <remarks/>
        public long itemId
        {
            get
            {
                return this.itemIdField;
            }
            set
            {
                this.itemIdField = value;
            }
        }
        
        /// <remarks/>
        public string itemTitle
        {
            get
            {
                return this.itemTitleField;
            }
            set
            {
                this.itemTitleField = value;
            }
        }
        
        /// <remarks/>
        public int leftCount
        {
            get
            {
                return this.leftCountField;
            }
            set
            {
                this.leftCountField = value;
            }
        }
        
        /// <remarks/>
        public int bidsCount
        {
            get
            {
                return this.bidsCountField;
            }
            set
            {
                this.bidsCountField = value;
            }
        }
        
        /// <remarks/>
        public int biddersCount
        {
            get
            {
                return this.biddersCountField;
            }
            set
            {
                this.biddersCountField = value;
            }
        }
        
        /// <remarks/>
        public string quantityType
        {
            get
            {
                return this.quantityTypeField;
            }
            set
            {
                this.quantityTypeField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime endingTime
        {
            get
            {
                return this.endingTimeField;
            }
            set
            {
                this.endingTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool endingTimeSpecified
        {
            get
            {
                return this.endingTimeFieldSpecified;
            }
            set
            {
                this.endingTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string timeToEnd
        {
            get
            {
                return this.timeToEndField;
            }
            set
            {
                this.timeToEndField = value;
            }
        }
        
        /// <remarks/>
        public int categoryId
        {
            get
            {
                return this.categoryIdField;
            }
            set
            {
                this.categoryIdField = value;
            }
        }
        
        /// <remarks/>
        public string conditionInfo
        {
            get
            {
                return this.conditionInfoField;
            }
            set
            {
                this.conditionInfoField = value;
            }
        }
        
        /// <remarks/>
        public int promotionInfo
        {
            get
            {
                return this.promotionInfoField;
            }
            set
            {
                this.promotionInfoField = value;
            }
        }
        
        /// <remarks/>
        public int additionalInfo
        {
            get
            {
                return this.additionalInfoField;
            }
            set
            {
                this.additionalInfoField = value;
            }
        }
        
        /// <remarks/>
        public UserInfoType sellerInfo
        {
            get
            {
                return this.sellerInfoField;
            }
            set
            {
                this.sellerInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public PriceInfoType[] priceInfo
        {
            get
            {
                return this.priceInfoField;
            }
            set
            {
                this.priceInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public PhotoInfoType[] photosInfo
        {
            get
            {
                return this.photosInfoField;
            }
            set
            {
                this.photosInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public ParameterInfoType[] parametersInfo
        {
            get
            {
                return this.parametersInfoField;
            }
            set
            {
                this.parametersInfoField = value;
            }
        }
        
        /// <remarks/>
        public AdvertInfoType advertInfo
        {
            get
            {
                return this.advertInfoField;
            }
            set
            {
                this.advertInfoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class SortOptionsType
    {
        
        private string sortTypeField;
        
        private string sortOrderField;
        
        /// <remarks/>
        public string sortType
        {
            get
            {
                return this.sortTypeField;
            }
            set
            {
                this.sortTypeField = value;
            }
        }
        
        /// <remarks/>
        public string sortOrder
        {
            get
            {
                return this.sortOrderField;
            }
            set
            {
                this.sortOrderField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class RangeValueType
    {
        
        private string rangeValueMinField;
        
        private string rangeValueMaxField;
        
        /// <remarks/>
        public string rangeValueMin
        {
            get
            {
                return this.rangeValueMinField;
            }
            set
            {
                this.rangeValueMinField = value;
            }
        }
        
        /// <remarks/>
        public string rangeValueMax
        {
            get
            {
                return this.rangeValueMaxField;
            }
            set
            {
                this.rangeValueMaxField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class FilterOptionsType
    {
        
        private string filterIdField;
        
        private string[] filterValueIdField;
        
        private RangeValueType filterValueRangeField;
        
        /// <remarks/>
        public string filterId
        {
            get
            {
                return this.filterIdField;
            }
            set
            {
                this.filterIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public string[] filterValueId
        {
            get
            {
                return this.filterValueIdField;
            }
            set
            {
                this.filterValueIdField = value;
            }
        }
        
        /// <remarks/>
        public RangeValueType filterValueRange
        {
            get
            {
                return this.filterValueRangeField;
            }
            set
            {
                this.filterValueRangeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ProductParametersStruct
    {
        
        private string productParameterNameField;
        
        private string[] productParameterValuesField;
        
        private string productParameterDescriptionField;
        
        /// <remarks/>
        public string productParameterName
        {
            get
            {
                return this.productParameterNameField;
            }
            set
            {
                this.productParameterNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public string[] productParameterValues
        {
            get
            {
                return this.productParameterValuesField;
            }
            set
            {
                this.productParameterValuesField = value;
            }
        }
        
        /// <remarks/>
        public string productParameterDescription
        {
            get
            {
                return this.productParameterDescriptionField;
            }
            set
            {
                this.productParameterDescriptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ProductParametersGroupStruct
    {
        
        private string productParametersGroupNameField;
        
        private ProductParametersStruct[] productParametersListField;
        
        /// <remarks/>
        public string productParametersGroupName
        {
            get
            {
                return this.productParametersGroupNameField;
            }
            set
            {
                this.productParametersGroupNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public ProductParametersStruct[] productParametersList
        {
            get
            {
                return this.productParametersListField;
            }
            set
            {
                this.productParametersListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ProductStruct
    {
        
        private long productIdField;
        
        private string productNameField;
        
        private string productDescriptionField;
        
        private string[] productImagesListField;
        
        private ProductParametersGroupStruct[] productParametersGroupListField;
        
        /// <remarks/>
        public long productId
        {
            get
            {
                return this.productIdField;
            }
            set
            {
                this.productIdField = value;
            }
        }
        
        /// <remarks/>
        public string productName
        {
            get
            {
                return this.productNameField;
            }
            set
            {
                this.productNameField = value;
            }
        }
        
        /// <remarks/>
        public string productDescription
        {
            get
            {
                return this.productDescriptionField;
            }
            set
            {
                this.productDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public string[] productImagesList
        {
            get
            {
                return this.productImagesListField;
            }
            set
            {
                this.productImagesListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public ProductParametersGroupStruct[] productParametersGroupList
        {
            get
            {
                return this.productParametersGroupListField;
            }
            set
            {
                this.productParametersGroupListField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class CompanyInfoStruct
    {
        
        private string companyFirstNameField;
        
        private string companyLastNameField;
        
        private string companyNameField;
        
        private string companyAddressField;
        
        private string companyPostcodeField;
        
        private string companyCityField;
        
        private string companyNipField;
        
        /// <remarks/>
        public string companyFirstName
        {
            get
            {
                return this.companyFirstNameField;
            }
            set
            {
                this.companyFirstNameField = value;
            }
        }
        
        /// <remarks/>
        public string companyLastName
        {
            get
            {
                return this.companyLastNameField;
            }
            set
            {
                this.companyLastNameField = value;
            }
        }
        
        /// <remarks/>
        public string companyName
        {
            get
            {
                return this.companyNameField;
            }
            set
            {
                this.companyNameField = value;
            }
        }
        
        /// <remarks/>
        public string companyAddress
        {
            get
            {
                return this.companyAddressField;
            }
            set
            {
                this.companyAddressField = value;
            }
        }
        
        /// <remarks/>
        public string companyPostcode
        {
            get
            {
                return this.companyPostcodeField;
            }
            set
            {
                this.companyPostcodeField = value;
            }
        }
        
        /// <remarks/>
        public string companyCity
        {
            get
            {
                return this.companyCityField;
            }
            set
            {
                this.companyCityField = value;
            }
        }
        
        /// <remarks/>
        public string companyNip
        {
            get
            {
                return this.companyNipField;
            }
            set
            {
                this.companyNipField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ItemPaymentOptions
    {
        
        private int payOptionTransferField;
        
        private int payOptionOnDeliveryField;
        
        private int payOptionAllegroPayField;
        
        private int payOptionSeeDescField;
        
        private int payOptionPayuField;
        
        private int payOptionEscrowField;
        
        private int payOptionQiwiField;
        
        /// <remarks/>
        public int payOptionTransfer
        {
            get
            {
                return this.payOptionTransferField;
            }
            set
            {
                this.payOptionTransferField = value;
            }
        }
        
        /// <remarks/>
        public int payOptionOnDelivery
        {
            get
            {
                return this.payOptionOnDeliveryField;
            }
            set
            {
                this.payOptionOnDeliveryField = value;
            }
        }
        
        /// <remarks/>
        public int payOptionAllegroPay
        {
            get
            {
                return this.payOptionAllegroPayField;
            }
            set
            {
                this.payOptionAllegroPayField = value;
            }
        }
        
        /// <remarks/>
        public int payOptionSeeDesc
        {
            get
            {
                return this.payOptionSeeDescField;
            }
            set
            {
                this.payOptionSeeDescField = value;
            }
        }
        
        /// <remarks/>
        public int payOptionPayu
        {
            get
            {
                return this.payOptionPayuField;
            }
            set
            {
                this.payOptionPayuField = value;
            }
        }
        
        /// <remarks/>
        public int payOptionEscrow
        {
            get
            {
                return this.payOptionEscrowField;
            }
            set
            {
                this.payOptionEscrowField = value;
            }
        }
        
        /// <remarks/>
        public int payOptionQiwi
        {
            get
            {
                return this.payOptionQiwiField;
            }
            set
            {
                this.payOptionQiwiField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class FulfillmentTimeStruct
    {
        
        private int fulfillmentTimeFromField;
        
        private int fulfillmentTimeToField;
        
        /// <remarks/>
        public int fulfillmentTimeFrom
        {
            get
            {
                return this.fulfillmentTimeFromField;
            }
            set
            {
                this.fulfillmentTimeFromField = value;
            }
        }
        
        /// <remarks/>
        public int fulfillmentTimeTo
        {
            get
            {
                return this.fulfillmentTimeToField;
            }
            set
            {
                this.fulfillmentTimeToField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PostageStruct
    {
        
        private float postageAmountField;
        
        private float postageAmountAddField;
        
        private int postagePackSizeField;
        
        private int postageIdField;
        
        private int postageFreeShippingField;
        
        private int postageFreeReturnField;
        
        private bool postageFreeReturnFieldSpecified;
        
        private FulfillmentTimeStruct postageFulfillmentTimeField;
        
        /// <remarks/>
        public float postageAmount
        {
            get
            {
                return this.postageAmountField;
            }
            set
            {
                this.postageAmountField = value;
            }
        }
        
        /// <remarks/>
        public float postageAmountAdd
        {
            get
            {
                return this.postageAmountAddField;
            }
            set
            {
                this.postageAmountAddField = value;
            }
        }
        
        /// <remarks/>
        public int postagePackSize
        {
            get
            {
                return this.postagePackSizeField;
            }
            set
            {
                this.postagePackSizeField = value;
            }
        }
        
        /// <remarks/>
        public int postageId
        {
            get
            {
                return this.postageIdField;
            }
            set
            {
                this.postageIdField = value;
            }
        }
        
        /// <remarks/>
        public int postageFreeShipping
        {
            get
            {
                return this.postageFreeShippingField;
            }
            set
            {
                this.postageFreeShippingField = value;
            }
        }
        
        /// <remarks/>
        public int postageFreeReturn
        {
            get
            {
                return this.postageFreeReturnField;
            }
            set
            {
                this.postageFreeReturnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool postageFreeReturnSpecified
        {
            get
            {
                return this.postageFreeReturnFieldSpecified;
            }
            set
            {
                this.postageFreeReturnFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public FulfillmentTimeStruct postageFulfillmentTime
        {
            get
            {
                return this.postageFulfillmentTimeField;
            }
            set
            {
                this.postageFulfillmentTimeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class AttribStruct
    {
        
        private string attribNameField;
        
        private string[] attribValuesField;
        
        /// <remarks/>
        public string attribName
        {
            get
            {
                return this.attribNameField;
            }
            set
            {
                this.attribNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public string[] attribValues
        {
            get
            {
                return this.attribValuesField;
            }
            set
            {
                this.attribValuesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ItemCatList
    {
        
        private int catLevelField;
        
        private long catIdField;
        
        private string catNameField;
        
        /// <remarks/>
        public int catLevel
        {
            get
            {
                return this.catLevelField;
            }
            set
            {
                this.catLevelField = value;
            }
        }
        
        /// <remarks/>
        public long catId
        {
            get
            {
                return this.catIdField;
            }
            set
            {
                this.catIdField = value;
            }
        }
        
        /// <remarks/>
        public string catName
        {
            get
            {
                return this.catNameField;
            }
            set
            {
                this.catNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ItemInfo
    {
        
        private long itIdField;
        
        private int itCountryField;
        
        private string itNameField;
        
        private float itPriceField;
        
        private int itBidCountField;
        
        private long itEndingTimeField;
        
        private long itSellerIdField;
        
        private string itSellerLoginField;
        
        private int itSellerRatingField;
        
        private long itStartingTimeField;
        
        private float itStartingPriceField;
        
        private int itQuantityField;
        
        private int itFotoCountField;
        
        private float itReservePriceField;
        
        private string itLocationField;
        
        private float itBuyNowPriceField;
        
        private int itBuyNowActiveField;
        
        private float itAdvertisementPriceField;
        
        private bool itAdvertisementPriceFieldSpecified;
        
        private int itAdvertisementActiveField;
        
        private bool itAdvertisementActiveFieldSpecified;
        
        private int itHighBidderField;
        
        private string itHighBidderLoginField;
        
        private string itDescriptionField;
        
        private string itStandardizedDescriptionField;
        
        private int itOptionsField;
        
        private int itStateField;
        
        private int itIsEcoField;
        
        private long itHitCountField;
        
        private string itPostcodeField;
        
        private int itVatInvoiceField;
        
        private int itVatMarginInvoiceField;
        
        private int itWithoutVatInvoiceField;
        
        private string itBankAccount1Field;
        
        private string itBankAccount2Field;
        
        private int itStartingQuantityField;
        
        private int itIsForGuestsField;
        
        private int itHasProductField;
        
        private int itOrderFulfillmentTimeField;
        
        private int itEndingInfoField;
        
        private int itIsAllegroStandardField;
        
        private int itIsNewUsedField;
        
        private int itIsBrandZoneField;
        
        private bool itIsBrandZoneFieldSpecified;
        
        private DurationInfoStruct itDurationInfoField;
        
        private int itIsFulfillmentTimeActiveField;
        
        private bool itIsFulfillmentTimeActiveFieldSpecified;
        
        private string itEanField;
        
        private string itContactField;
        
        /// <remarks/>
        public long itId
        {
            get
            {
                return this.itIdField;
            }
            set
            {
                this.itIdField = value;
            }
        }
        
        /// <remarks/>
        public int itCountry
        {
            get
            {
                return this.itCountryField;
            }
            set
            {
                this.itCountryField = value;
            }
        }
        
        /// <remarks/>
        public string itName
        {
            get
            {
                return this.itNameField;
            }
            set
            {
                this.itNameField = value;
            }
        }
        
        /// <remarks/>
        public float itPrice
        {
            get
            {
                return this.itPriceField;
            }
            set
            {
                this.itPriceField = value;
            }
        }
        
        /// <remarks/>
        public int itBidCount
        {
            get
            {
                return this.itBidCountField;
            }
            set
            {
                this.itBidCountField = value;
            }
        }
        
        /// <remarks/>
        public long itEndingTime
        {
            get
            {
                return this.itEndingTimeField;
            }
            set
            {
                this.itEndingTimeField = value;
            }
        }
        
        /// <remarks/>
        public long itSellerId
        {
            get
            {
                return this.itSellerIdField;
            }
            set
            {
                this.itSellerIdField = value;
            }
        }
        
        /// <remarks/>
        public string itSellerLogin
        {
            get
            {
                return this.itSellerLoginField;
            }
            set
            {
                this.itSellerLoginField = value;
            }
        }
        
        /// <remarks/>
        public int itSellerRating
        {
            get
            {
                return this.itSellerRatingField;
            }
            set
            {
                this.itSellerRatingField = value;
            }
        }
        
        /// <remarks/>
        public long itStartingTime
        {
            get
            {
                return this.itStartingTimeField;
            }
            set
            {
                this.itStartingTimeField = value;
            }
        }
        
        /// <remarks/>
        public float itStartingPrice
        {
            get
            {
                return this.itStartingPriceField;
            }
            set
            {
                this.itStartingPriceField = value;
            }
        }
        
        /// <remarks/>
        public int itQuantity
        {
            get
            {
                return this.itQuantityField;
            }
            set
            {
                this.itQuantityField = value;
            }
        }
        
        /// <remarks/>
        public int itFotoCount
        {
            get
            {
                return this.itFotoCountField;
            }
            set
            {
                this.itFotoCountField = value;
            }
        }
        
        /// <remarks/>
        public float itReservePrice
        {
            get
            {
                return this.itReservePriceField;
            }
            set
            {
                this.itReservePriceField = value;
            }
        }
        
        /// <remarks/>
        public string itLocation
        {
            get
            {
                return this.itLocationField;
            }
            set
            {
                this.itLocationField = value;
            }
        }
        
        /// <remarks/>
        public float itBuyNowPrice
        {
            get
            {
                return this.itBuyNowPriceField;
            }
            set
            {
                this.itBuyNowPriceField = value;
            }
        }
        
        /// <remarks/>
        public int itBuyNowActive
        {
            get
            {
                return this.itBuyNowActiveField;
            }
            set
            {
                this.itBuyNowActiveField = value;
            }
        }
        
        /// <remarks/>
        public float itAdvertisementPrice
        {
            get
            {
                return this.itAdvertisementPriceField;
            }
            set
            {
                this.itAdvertisementPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itAdvertisementPriceSpecified
        {
            get
            {
                return this.itAdvertisementPriceFieldSpecified;
            }
            set
            {
                this.itAdvertisementPriceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int itAdvertisementActive
        {
            get
            {
                return this.itAdvertisementActiveField;
            }
            set
            {
                this.itAdvertisementActiveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itAdvertisementActiveSpecified
        {
            get
            {
                return this.itAdvertisementActiveFieldSpecified;
            }
            set
            {
                this.itAdvertisementActiveFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int itHighBidder
        {
            get
            {
                return this.itHighBidderField;
            }
            set
            {
                this.itHighBidderField = value;
            }
        }
        
        /// <remarks/>
        public string itHighBidderLogin
        {
            get
            {
                return this.itHighBidderLoginField;
            }
            set
            {
                this.itHighBidderLoginField = value;
            }
        }
        
        /// <remarks/>
        public string itDescription
        {
            get
            {
                return this.itDescriptionField;
            }
            set
            {
                this.itDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public string itStandardizedDescription
        {
            get
            {
                return this.itStandardizedDescriptionField;
            }
            set
            {
                this.itStandardizedDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public int itOptions
        {
            get
            {
                return this.itOptionsField;
            }
            set
            {
                this.itOptionsField = value;
            }
        }
        
        /// <remarks/>
        public int itState
        {
            get
            {
                return this.itStateField;
            }
            set
            {
                this.itStateField = value;
            }
        }
        
        /// <remarks/>
        public int itIsEco
        {
            get
            {
                return this.itIsEcoField;
            }
            set
            {
                this.itIsEcoField = value;
            }
        }
        
        /// <remarks/>
        public long itHitCount
        {
            get
            {
                return this.itHitCountField;
            }
            set
            {
                this.itHitCountField = value;
            }
        }
        
        /// <remarks/>
        public string itPostcode
        {
            get
            {
                return this.itPostcodeField;
            }
            set
            {
                this.itPostcodeField = value;
            }
        }
        
        /// <remarks/>
        public int itVatInvoice
        {
            get
            {
                return this.itVatInvoiceField;
            }
            set
            {
                this.itVatInvoiceField = value;
            }
        }
        
        /// <remarks/>
        public int itVatMarginInvoice
        {
            get
            {
                return this.itVatMarginInvoiceField;
            }
            set
            {
                this.itVatMarginInvoiceField = value;
            }
        }
        
        /// <remarks/>
        public int itWithoutVatInvoice
        {
            get
            {
                return this.itWithoutVatInvoiceField;
            }
            set
            {
                this.itWithoutVatInvoiceField = value;
            }
        }
        
        /// <remarks/>
        public string itBankAccount1
        {
            get
            {
                return this.itBankAccount1Field;
            }
            set
            {
                this.itBankAccount1Field = value;
            }
        }
        
        /// <remarks/>
        public string itBankAccount2
        {
            get
            {
                return this.itBankAccount2Field;
            }
            set
            {
                this.itBankAccount2Field = value;
            }
        }
        
        /// <remarks/>
        public int itStartingQuantity
        {
            get
            {
                return this.itStartingQuantityField;
            }
            set
            {
                this.itStartingQuantityField = value;
            }
        }
        
        /// <remarks/>
        public int itIsForGuests
        {
            get
            {
                return this.itIsForGuestsField;
            }
            set
            {
                this.itIsForGuestsField = value;
            }
        }
        
        /// <remarks/>
        public int itHasProduct
        {
            get
            {
                return this.itHasProductField;
            }
            set
            {
                this.itHasProductField = value;
            }
        }
        
        /// <remarks/>
        public int itOrderFulfillmentTime
        {
            get
            {
                return this.itOrderFulfillmentTimeField;
            }
            set
            {
                this.itOrderFulfillmentTimeField = value;
            }
        }
        
        /// <remarks/>
        public int itEndingInfo
        {
            get
            {
                return this.itEndingInfoField;
            }
            set
            {
                this.itEndingInfoField = value;
            }
        }
        
        /// <remarks/>
        public int itIsAllegroStandard
        {
            get
            {
                return this.itIsAllegroStandardField;
            }
            set
            {
                this.itIsAllegroStandardField = value;
            }
        }
        
        /// <remarks/>
        public int itIsNewUsed
        {
            get
            {
                return this.itIsNewUsedField;
            }
            set
            {
                this.itIsNewUsedField = value;
            }
        }
        
        /// <remarks/>
        public int itIsBrandZone
        {
            get
            {
                return this.itIsBrandZoneField;
            }
            set
            {
                this.itIsBrandZoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itIsBrandZoneSpecified
        {
            get
            {
                return this.itIsBrandZoneFieldSpecified;
            }
            set
            {
                this.itIsBrandZoneFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public DurationInfoStruct itDurationInfo
        {
            get
            {
                return this.itDurationInfoField;
            }
            set
            {
                this.itDurationInfoField = value;
            }
        }
        
        /// <remarks/>
        public int itIsFulfillmentTimeActive
        {
            get
            {
                return this.itIsFulfillmentTimeActiveField;
            }
            set
            {
                this.itIsFulfillmentTimeActiveField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itIsFulfillmentTimeActiveSpecified
        {
            get
            {
                return this.itIsFulfillmentTimeActiveFieldSpecified;
            }
            set
            {
                this.itIsFulfillmentTimeActiveFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string itEan
        {
            get
            {
                return this.itEanField;
            }
            set
            {
                this.itEanField = value;
            }
        }
        
        /// <remarks/>
        public string itContact
        {
            get
            {
                return this.itContactField;
            }
            set
            {
                this.itContactField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ItemInfoStruct
    {
        
        private ItemInfo itemInfoField;
        
        private ItemCatList[] itemCatsField;
        
        private ItemImageList[] itemImagesField;
        
        private AttribStruct[] itemAttribsField;
        
        private PostageStruct[] itemPostageOptionsField;
        
        private ItemPaymentOptions itemPaymentOptionsField;
        
        private CompanyInfoStruct itemCompanyInfoField;
        
        private ProductStruct itemProductInfoField;
        
        private AfterSalesServiceConditionsStruct itemAfterSalesServiceConditionsField;
        
        private string itemAdditionalServicesGroupField;
        
        /// <remarks/>
        public ItemInfo itemInfo
        {
            get
            {
                return this.itemInfoField;
            }
            set
            {
                this.itemInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public ItemCatList[] itemCats
        {
            get
            {
                return this.itemCatsField;
            }
            set
            {
                this.itemCatsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public ItemImageList[] itemImages
        {
            get
            {
                return this.itemImagesField;
            }
            set
            {
                this.itemImagesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public AttribStruct[] itemAttribs
        {
            get
            {
                return this.itemAttribsField;
            }
            set
            {
                this.itemAttribsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public PostageStruct[] itemPostageOptions
        {
            get
            {
                return this.itemPostageOptionsField;
            }
            set
            {
                this.itemPostageOptionsField = value;
            }
        }
        
        /// <remarks/>
        public ItemPaymentOptions itemPaymentOptions
        {
            get
            {
                return this.itemPaymentOptionsField;
            }
            set
            {
                this.itemPaymentOptionsField = value;
            }
        }
        
        /// <remarks/>
        public CompanyInfoStruct itemCompanyInfo
        {
            get
            {
                return this.itemCompanyInfoField;
            }
            set
            {
                this.itemCompanyInfoField = value;
            }
        }
        
        /// <remarks/>
        public ProductStruct itemProductInfo
        {
            get
            {
                return this.itemProductInfoField;
            }
            set
            {
                this.itemProductInfoField = value;
            }
        }
        
        /// <remarks/>
        public AfterSalesServiceConditionsStruct itemAfterSalesServiceConditions
        {
            get
            {
                return this.itemAfterSalesServiceConditionsField;
            }
            set
            {
                this.itemAfterSalesServiceConditionsField = value;
            }
        }
        
        /// <remarks/>
        public string itemAdditionalServicesGroup
        {
            get
            {
                return this.itemAdditionalServicesGroupField;
            }
            set
            {
                this.itemAdditionalServicesGroupField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ItemImageList
    {
        
        private int imageTypeField;
        
        private string imageUrlField;
        
        /// <remarks/>
        public int imageType
        {
            get
            {
                return this.imageTypeField;
            }
            set
            {
                this.imageTypeField = value;
            }
        }
        
        /// <remarks/>
        public string imageUrl
        {
            get
            {
                return this.imageUrlField;
            }
            set
            {
                this.imageUrlField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class AfterSalesServiceConditionsStruct
    {
        
        private string impliedWarrantyField;
        
        private string returnPolicyField;
        
        private string warrantyField;
        
        /// <remarks/>
        public string impliedWarranty
        {
            get
            {
                return this.impliedWarrantyField;
            }
            set
            {
                this.impliedWarrantyField = value;
            }
        }
        
        /// <remarks/>
        public string returnPolicy
        {
            get
            {
                return this.returnPolicyField;
            }
            set
            {
                this.returnPolicyField = value;
            }
        }
        
        /// <remarks/>
        public string warranty
        {
            get
            {
                return this.warrantyField;
            }
            set
            {
                this.warrantyField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ItemImagesStruct
    {
        
        private long itemIdField;
        
        private ItemImageList[] itemImagesField;
        
        /// <remarks/>
        public long itemId
        {
            get
            {
                return this.itemIdField;
            }
            set
            {
                this.itemIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public ItemImageList[] itemImages
        {
            get
            {
                return this.itemImagesField;
            }
            set
            {
                this.itemImagesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ItemGetImage
    {
        
        private long itIdField;
        
        private long itSellerIdField;
        
        private int itFotoCountField;
        
        /// <remarks/>
        public long itId
        {
            get
            {
                return this.itIdField;
            }
            set
            {
                this.itIdField = value;
            }
        }
        
        /// <remarks/>
        public long itSellerId
        {
            get
            {
                return this.itSellerIdField;
            }
            set
            {
                this.itSellerIdField = value;
            }
        }
        
        /// <remarks/>
        public int itFotoCount
        {
            get
            {
                return this.itFotoCountField;
            }
            set
            {
                this.itFotoCountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class FilledPostBuyFormsStruct
    {
        
        private long[] transactionIdsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] transactionIds
        {
            get
            {
                return this.transactionIdsField;
            }
            set
            {
                this.transactionIdsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class DealsStruct
    {
        
        private long dealIdField;
        
        private long dealDateField;
        
        private int dealQuantityField;
        
        private float dealAmountOriginalField;
        
        private float dealAmountDiscountedField;
        
        /// <remarks/>
        public long dealId
        {
            get
            {
                return this.dealIdField;
            }
            set
            {
                this.dealIdField = value;
            }
        }
        
        /// <remarks/>
        public long dealDate
        {
            get
            {
                return this.dealDateField;
            }
            set
            {
                this.dealDateField = value;
            }
        }
        
        /// <remarks/>
        public int dealQuantity
        {
            get
            {
                return this.dealQuantityField;
            }
            set
            {
                this.dealQuantityField = value;
            }
        }
        
        /// <remarks/>
        public float dealAmountOriginal
        {
            get
            {
                return this.dealAmountOriginalField;
            }
            set
            {
                this.dealAmountOriginalField = value;
            }
        }
        
        /// <remarks/>
        public float dealAmountDiscounted
        {
            get
            {
                return this.dealAmountDiscountedField;
            }
            set
            {
                this.dealAmountDiscountedField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class CountryInfoType
    {
        
        private int countryIdField;
        
        private string countryNameField;
        
        /// <remarks/>
        public int countryId
        {
            get
            {
                return this.countryIdField;
            }
            set
            {
                this.countryIdField = value;
            }
        }
        
        /// <remarks/>
        public string countryName
        {
            get
            {
                return this.countryNameField;
            }
            set
            {
                this.countryNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class CatInfoType
    {
        
        private int catIdField;
        
        private string catNameField;
        
        private int catParentField;
        
        private int catPositionField;
        
        private int catIsProductCatalogueEnabledField;
        
        private bool catIsLeafField;
        
        private bool catIsLeafFieldSpecified;
        
        /// <remarks/>
        public int catId
        {
            get
            {
                return this.catIdField;
            }
            set
            {
                this.catIdField = value;
            }
        }
        
        /// <remarks/>
        public string catName
        {
            get
            {
                return this.catNameField;
            }
            set
            {
                this.catNameField = value;
            }
        }
        
        /// <remarks/>
        public int catParent
        {
            get
            {
                return this.catParentField;
            }
            set
            {
                this.catParentField = value;
            }
        }
        
        /// <remarks/>
        public int catPosition
        {
            get
            {
                return this.catPositionField;
            }
            set
            {
                this.catPositionField = value;
            }
        }
        
        /// <remarks/>
        public int catIsProductCatalogueEnabled
        {
            get
            {
                return this.catIsProductCatalogueEnabledField;
            }
            set
            {
                this.catIsProductCatalogueEnabledField = value;
            }
        }
        
        /// <remarks/>
        public bool catIsLeaf
        {
            get
            {
                return this.catIsLeafField;
            }
            set
            {
                this.catIsLeafField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool catIsLeafSpecified
        {
            get
            {
                return this.catIsLeafFieldSpecified;
            }
            set
            {
                this.catIsLeafFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class CategoryData
    {
        
        private int catIdField;
        
        private int catParentField;
        
        private int catCountryField;
        
        private int catLevelField;
        
        private int catIsLeafField;
        
        private string catNameField;
        
        private int catOptionsField;
        
        /// <remarks/>
        public int catId
        {
            get
            {
                return this.catIdField;
            }
            set
            {
                this.catIdField = value;
            }
        }
        
        /// <remarks/>
        public int catParent
        {
            get
            {
                return this.catParentField;
            }
            set
            {
                this.catParentField = value;
            }
        }
        
        /// <remarks/>
        public int catCountry
        {
            get
            {
                return this.catCountryField;
            }
            set
            {
                this.catCountryField = value;
            }
        }
        
        /// <remarks/>
        public int catLevel
        {
            get
            {
                return this.catLevelField;
            }
            set
            {
                this.catLevelField = value;
            }
        }
        
        /// <remarks/>
        public int catIsLeaf
        {
            get
            {
                return this.catIsLeafField;
            }
            set
            {
                this.catIsLeafField = value;
            }
        }
        
        /// <remarks/>
        public string catName
        {
            get
            {
                return this.catNameField;
            }
            set
            {
                this.catNameField = value;
            }
        }
        
        /// <remarks/>
        public int catOptions
        {
            get
            {
                return this.catOptionsField;
            }
            set
            {
                this.catOptionsField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class BlackListStruct
    {
        
        private long userIdField;
        
        private string userLoginField;
        
        private int userRatingField;
        
        private int userCountryField;
        
        /// <remarks/>
        public long userId
        {
            get
            {
                return this.userIdField;
            }
            set
            {
                this.userIdField = value;
            }
        }
        
        /// <remarks/>
        public string userLogin
        {
            get
            {
                return this.userLoginField;
            }
            set
            {
                this.userLoginField = value;
            }
        }
        
        /// <remarks/>
        public int userRating
        {
            get
            {
                return this.userRatingField;
            }
            set
            {
                this.userRatingField = value;
            }
        }
        
        /// <remarks/>
        public int userCountry
        {
            get
            {
                return this.userCountryField;
            }
            set
            {
                this.userCountryField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class BidListStruct2
    {
        
        private string[] bidsArrayField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public string[] bidsArray
        {
            get
            {
                return this.bidsArrayField;
            }
            set
            {
                this.bidsArrayField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ArchiveRefundsListTypeStruct
    {
        
        private int refundIdField;
        
        private int buyerIdField;
        
        private string buyerLoginField;
        
        /// <remarks/>
        public int refundId
        {
            get
            {
                return this.refundIdField;
            }
            set
            {
                this.refundIdField = value;
            }
        }
        
        /// <remarks/>
        public int buyerId
        {
            get
            {
                return this.buyerIdField;
            }
            set
            {
                this.buyerIdField = value;
            }
        }
        
        /// <remarks/>
        public string buyerLogin
        {
            get
            {
                return this.buyerLoginField;
            }
            set
            {
                this.buyerLoginField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class FinishFailureStruct
    {
        
        private long finishItemIdField;
        
        private string finishErrorCodeField;
        
        private string finishErrorMessageField;
        
        /// <remarks/>
        public long finishItemId
        {
            get
            {
                return this.finishItemIdField;
            }
            set
            {
                this.finishItemIdField = value;
            }
        }
        
        /// <remarks/>
        public string finishErrorCode
        {
            get
            {
                return this.finishErrorCodeField;
            }
            set
            {
                this.finishErrorCodeField = value;
            }
        }
        
        /// <remarks/>
        public string finishErrorMessage
        {
            get
            {
                return this.finishErrorMessageField;
            }
            set
            {
                this.finishErrorMessageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class FinishItemsStruct
    {
        
        private long finishItemIdField;
        
        private int finishCancelAllBidsField;
        
        private bool finishCancelAllBidsFieldSpecified;
        
        private string finishCancelReasonField;
        
        /// <remarks/>
        public long finishItemId
        {
            get
            {
                return this.finishItemIdField;
            }
            set
            {
                this.finishItemIdField = value;
            }
        }
        
        /// <remarks/>
        public int finishCancelAllBids
        {
            get
            {
                return this.finishCancelAllBidsField;
            }
            set
            {
                this.finishCancelAllBidsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool finishCancelAllBidsSpecified
        {
            get
            {
                return this.finishCancelAllBidsFieldSpecified;
            }
            set
            {
                this.finishCancelAllBidsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string finishCancelReason
        {
            get
            {
                return this.finishCancelReasonField;
            }
            set
            {
                this.finishCancelReasonField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ItemDescriptionStruct
    {
        
        private string descriptionResultField;
        
        /// <remarks/>
        public string descriptionResult
        {
            get
            {
                return this.descriptionResultField;
            }
            set
            {
                this.descriptionResultField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class AmountStruct
    {
        
        private float amountValueField;
        
        private string amountCurrencySignField;
        
        /// <remarks/>
        public float amountValue
        {
            get
            {
                return this.amountValueField;
            }
            set
            {
                this.amountValueField = value;
            }
        }
        
        /// <remarks/>
        public string amountCurrencySign
        {
            get
            {
                return this.amountCurrencySignField;
            }
            set
            {
                this.amountCurrencySignField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ItemSurchargeStruct
    {
        
        private string surchargeDescriptionField;
        
        private AmountStruct surchargeAmountField;
        
        /// <remarks/>
        public string surchargeDescription
        {
            get
            {
                return this.surchargeDescriptionField;
            }
            set
            {
                this.surchargeDescriptionField = value;
            }
        }
        
        /// <remarks/>
        public AmountStruct surchargeAmount
        {
            get
            {
                return this.surchargeAmountField;
            }
            set
            {
                this.surchargeAmountField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class ChangedItemStruct
    {
        
        private long itemIdField;
        
        private FieldsValue[] itemFieldsField;
        
        private ItemSurchargeStruct[] itemSurchargeField;
        
        /// <remarks/>
        public long itemId
        {
            get
            {
                return this.itemIdField;
            }
            set
            {
                this.itemIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public FieldsValue[] itemFields
        {
            get
            {
                return this.itemFieldsField;
            }
            set
            {
                this.itemFieldsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public ItemSurchargeStruct[] itemSurcharge
        {
            get
            {
                return this.itemSurchargeField;
            }
            set
            {
                this.itemSurchargeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class FieldsValue
    {
        
        private int fidField;
        
        private string fvalueStringField;
        
        private int fvalueIntField;
        
        private bool fvalueIntFieldSpecified;
        
        private float fvalueFloatField;
        
        private bool fvalueFloatFieldSpecified;
        
        private byte[] fvalueImageField;
        
        private float fvalueDatetimeField;
        
        private bool fvalueDatetimeFieldSpecified;
        
        private string fvalueDateField;
        
        private RangeIntValueStruct fvalueRangeIntField;
        
        private RangeFloatValueStruct fvalueRangeFloatField;
        
        private RangeDateValueStruct fvalueRangeDateField;
        
        /// <remarks/>
        public int fid
        {
            get
            {
                return this.fidField;
            }
            set
            {
                this.fidField = value;
            }
        }
        
        /// <remarks/>
        public string fvalueString
        {
            get
            {
                return this.fvalueStringField;
            }
            set
            {
                this.fvalueStringField = value;
            }
        }
        
        /// <remarks/>
        public int fvalueInt
        {
            get
            {
                return this.fvalueIntField;
            }
            set
            {
                this.fvalueIntField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fvalueIntSpecified
        {
            get
            {
                return this.fvalueIntFieldSpecified;
            }
            set
            {
                this.fvalueIntFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public float fvalueFloat
        {
            get
            {
                return this.fvalueFloatField;
            }
            set
            {
                this.fvalueFloatField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fvalueFloatSpecified
        {
            get
            {
                return this.fvalueFloatFieldSpecified;
            }
            set
            {
                this.fvalueFloatFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] fvalueImage
        {
            get
            {
                return this.fvalueImageField;
            }
            set
            {
                this.fvalueImageField = value;
            }
        }
        
        /// <remarks/>
        public float fvalueDatetime
        {
            get
            {
                return this.fvalueDatetimeField;
            }
            set
            {
                this.fvalueDatetimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fvalueDatetimeSpecified
        {
            get
            {
                return this.fvalueDatetimeFieldSpecified;
            }
            set
            {
                this.fvalueDatetimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string fvalueDate
        {
            get
            {
                return this.fvalueDateField;
            }
            set
            {
                this.fvalueDateField = value;
            }
        }
        
        /// <remarks/>
        public RangeIntValueStruct fvalueRangeInt
        {
            get
            {
                return this.fvalueRangeIntField;
            }
            set
            {
                this.fvalueRangeIntField = value;
            }
        }
        
        /// <remarks/>
        public RangeFloatValueStruct fvalueRangeFloat
        {
            get
            {
                return this.fvalueRangeFloatField;
            }
            set
            {
                this.fvalueRangeFloatField = value;
            }
        }
        
        /// <remarks/>
        public RangeDateValueStruct fvalueRangeDate
        {
            get
            {
                return this.fvalueRangeDateField;
            }
            set
            {
                this.fvalueRangeDateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class RangeIntValueStruct
    {
        
        private int fvalueRangeIntMinField;
        
        private bool fvalueRangeIntMinFieldSpecified;
        
        private int fvalueRangeIntMaxField;
        
        private bool fvalueRangeIntMaxFieldSpecified;
        
        /// <remarks/>
        public int fvalueRangeIntMin
        {
            get
            {
                return this.fvalueRangeIntMinField;
            }
            set
            {
                this.fvalueRangeIntMinField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fvalueRangeIntMinSpecified
        {
            get
            {
                return this.fvalueRangeIntMinFieldSpecified;
            }
            set
            {
                this.fvalueRangeIntMinFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public int fvalueRangeIntMax
        {
            get
            {
                return this.fvalueRangeIntMaxField;
            }
            set
            {
                this.fvalueRangeIntMaxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fvalueRangeIntMaxSpecified
        {
            get
            {
                return this.fvalueRangeIntMaxFieldSpecified;
            }
            set
            {
                this.fvalueRangeIntMaxFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class RangeFloatValueStruct
    {
        
        private float fvalueRangeFloatMinField;
        
        private bool fvalueRangeFloatMinFieldSpecified;
        
        private float fvalueRangeFloatMaxField;
        
        private bool fvalueRangeFloatMaxFieldSpecified;
        
        /// <remarks/>
        public float fvalueRangeFloatMin
        {
            get
            {
                return this.fvalueRangeFloatMinField;
            }
            set
            {
                this.fvalueRangeFloatMinField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fvalueRangeFloatMinSpecified
        {
            get
            {
                return this.fvalueRangeFloatMinFieldSpecified;
            }
            set
            {
                this.fvalueRangeFloatMinFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public float fvalueRangeFloatMax
        {
            get
            {
                return this.fvalueRangeFloatMaxField;
            }
            set
            {
                this.fvalueRangeFloatMaxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool fvalueRangeFloatMaxSpecified
        {
            get
            {
                return this.fvalueRangeFloatMaxFieldSpecified;
            }
            set
            {
                this.fvalueRangeFloatMaxFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class RangeDateValueStruct
    {
        
        private string fvalueRangeDateMinField;
        
        private string fvalueRangeDateMaxField;
        
        /// <remarks/>
        public string fvalueRangeDateMin
        {
            get
            {
                return this.fvalueRangeDateMinField;
            }
            set
            {
                this.fvalueRangeDateMinField = value;
            }
        }
        
        /// <remarks/>
        public string fvalueRangeDateMax
        {
            get
            {
                return this.fvalueRangeDateMaxField;
            }
            set
            {
                this.fvalueRangeDateMaxField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class TagNameStruct
    {
        
        private string tagNameField;
        
        /// <remarks/>
        public string tagName
        {
            get
            {
                return this.tagNameField;
            }
            set
            {
                this.tagNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class VariantQuantityStruct
    {
        
        private int maskField;
        
        private int quantityField;
        
        /// <remarks/>
        public int mask
        {
            get
            {
                return this.maskField;
            }
            set
            {
                this.maskField = value;
            }
        }
        
        /// <remarks/>
        public int quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class VariantStruct
    {
        
        private int fidField;
        
        private VariantQuantityStruct[] quantitiesField;
        
        /// <remarks/>
        public int fid
        {
            get
            {
                return this.fidField;
            }
            set
            {
                this.fidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public VariantQuantityStruct[] quantities
        {
            get
            {
                return this.quantitiesField;
            }
            set
            {
                this.quantitiesField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PharmacyRecipientDataStruct
    {
        
        private string recipientFirstNameField;
        
        private string recipientLastNameField;
        
        private string recipientAddressField;
        
        private string recipientPostcodeField;
        
        private string recipientCityField;
        
        /// <remarks/>
        public string recipientFirstName
        {
            get
            {
                return this.recipientFirstNameField;
            }
            set
            {
                this.recipientFirstNameField = value;
            }
        }
        
        /// <remarks/>
        public string recipientLastName
        {
            get
            {
                return this.recipientLastNameField;
            }
            set
            {
                this.recipientLastNameField = value;
            }
        }
        
        /// <remarks/>
        public string recipientAddress
        {
            get
            {
                return this.recipientAddressField;
            }
            set
            {
                this.recipientAddressField = value;
            }
        }
        
        /// <remarks/>
        public string recipientPostcode
        {
            get
            {
                return this.recipientPostcodeField;
            }
            set
            {
                this.recipientPostcodeField = value;
            }
        }
        
        /// <remarks/>
        public string recipientCity
        {
            get
            {
                return this.recipientCityField;
            }
            set
            {
                this.recipientCityField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class UserBlackListAddResultStruct
    {
        
        private int userIdField;
        
        private int addToBlackListResultField;
        
        private string addToBlackListErrCodeField;
        
        private string addToBlackListErrMsgField;
        
        /// <remarks/>
        public int userId
        {
            get
            {
                return this.userIdField;
            }
            set
            {
                this.userIdField = value;
            }
        }
        
        /// <remarks/>
        public int addToBlackListResult
        {
            get
            {
                return this.addToBlackListResultField;
            }
            set
            {
                this.addToBlackListResultField = value;
            }
        }
        
        /// <remarks/>
        public string addToBlackListErrCode
        {
            get
            {
                return this.addToBlackListErrCodeField;
            }
            set
            {
                this.addToBlackListErrCodeField = value;
            }
        }
        
        /// <remarks/>
        public string addToBlackListErrMsg
        {
            get
            {
                return this.addToBlackListErrMsgField;
            }
            set
            {
                this.addToBlackListErrMsgField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class UserBlackListStruct
    {
        
        private int userIdField;
        
        private string userBlackListNoteField;
        
        /// <remarks/>
        public int userId
        {
            get
            {
                return this.userIdField;
            }
            set
            {
                this.userIdField = value;
            }
        }
        
        /// <remarks/>
        public string userBlackListNote
        {
            get
            {
                return this.userBlackListNoteField;
            }
            set
            {
                this.userBlackListNoteField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="https://webapi.allegro.pl/service.php")]
    public partial class PostBuyFormPackageInfoStruct
    {
        
        private string[] packageIdsAddedField;
        
        private string[] packageIdsNotAddedIncorrectOperatorIdField;
        
        private string[] packageIdsNotAddedIncorrectPackageIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public string[] packageIdsAdded
        {
            get
            {
                return this.packageIdsAddedField;
            }
            set
            {
                this.packageIdsAddedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public string[] packageIdsNotAddedIncorrectOperatorId
        {
            get
            {
                return this.packageIdsNotAddedIncorrectOperatorIdField;
            }
            set
            {
                this.packageIdsNotAddedIncorrectOperatorIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public string[] packageIdsNotAddedIncorrectPackageId
        {
            get
            {
                return this.packageIdsNotAddedIncorrectPackageIdField;
            }
            set
            {
                this.packageIdsNotAddedIncorrectPackageIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoAddPackageInfoToPostBuyFormRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doAddPackageInfoToPostBuyFormRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long transactionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.PackageInfoStruct[] packageInfo;
        
        public doAddPackageInfoToPostBuyFormRequest()
        {
        }
        
        public doAddPackageInfoToPostBuyFormRequest(string sessionId, long transactionId, Allegro.PackageInfoStruct[] packageInfo)
        {
            this.sessionId = sessionId;
            this.transactionId = transactionId;
            this.packageInfo = packageInfo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doAddPackageInfoToPostBuyFormResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doAddPackageInfoToPostBuyFormResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public Allegro.PostBuyFormPackageInfoStruct postBuyFormPackageInfo;
        
        public doAddPackageInfoToPostBuyFormResponse()
        {
        }
        
        public doAddPackageInfoToPostBuyFormResponse(Allegro.PostBuyFormPackageInfoStruct postBuyFormPackageInfo)
        {
            this.postBuyFormPackageInfo = postBuyFormPackageInfo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoAddToBlackListRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doAddToBlackListRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.UserBlackListStruct[] usersBlackListArray;
        
        public doAddToBlackListRequest()
        {
        }
        
        public doAddToBlackListRequest(string sessionHandle, Allegro.UserBlackListStruct[] usersBlackListArray)
        {
            this.sessionHandle = sessionHandle;
            this.usersBlackListArray = usersBlackListArray;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doAddToBlackListResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doAddToBlackListResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.UserBlackListAddResultStruct[] userBlackListResultsArr;
        
        public doAddToBlackListResponse()
        {
        }
        
        public doAddToBlackListResponse(Allegro.UserBlackListAddResultStruct[] userBlackListResultsArr)
        {
            this.userBlackListResultsArr = userBlackListResultsArr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoBidItemRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doBidItemRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long bidItId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public float bidUserPrice;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public long bidQuantity;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public long bidBuyNow;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=5)]
        public Allegro.PharmacyRecipientDataStruct pharmacyRecipientData;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=6)]
        public string variantId;
        
        public doBidItemRequest()
        {
        }
        
        public doBidItemRequest(string sessionHandle, long bidItId, float bidUserPrice, long bidQuantity, long bidBuyNow, Allegro.PharmacyRecipientDataStruct pharmacyRecipientData, string variantId)
        {
            this.sessionHandle = sessionHandle;
            this.bidItId = bidItId;
            this.bidUserPrice = bidUserPrice;
            this.bidQuantity = bidQuantity;
            this.bidBuyNow = bidBuyNow;
            this.pharmacyRecipientData = pharmacyRecipientData;
            this.variantId = variantId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doBidItemResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doBidItemResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string bidPrice;
        
        public doBidItemResponse()
        {
        }
        
        public doBidItemResponse(string bidPrice)
        {
            this.bidPrice = bidPrice;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoCancelBidItemRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doCancelBidItemRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long cancelItemId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public int[] cancelBidsArray;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public string cancelBidsReason;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public long cancelAddToBlackList;
        
        public doCancelBidItemRequest()
        {
        }
        
        public doCancelBidItemRequest(string sessionHandle, long cancelItemId, int[] cancelBidsArray, string cancelBidsReason, long cancelAddToBlackList)
        {
            this.sessionHandle = sessionHandle;
            this.cancelItemId = cancelItemId;
            this.cancelBidsArray = cancelBidsArray;
            this.cancelBidsReason = cancelBidsReason;
            this.cancelAddToBlackList = cancelAddToBlackList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doCancelBidItemResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doCancelBidItemResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int cancelBidValue;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public int[] cancelledBids;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public int[] notCancelledBids;
        
        public doCancelBidItemResponse()
        {
        }
        
        public doCancelBidItemResponse(int cancelBidValue, int[] cancelledBids, int[] notCancelledBids)
        {
            this.cancelBidValue = cancelBidValue;
            this.cancelledBids = cancelledBids;
            this.notCancelledBids = notCancelledBids;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoCancelRefundFormRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doCancelRefundFormRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public int refundId;
        
        public doCancelRefundFormRequest()
        {
        }
        
        public doCancelRefundFormRequest(string sessionId, int refundId)
        {
            this.sessionId = sessionId;
            this.refundId = refundId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doCancelRefundFormResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doCancelRefundFormResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public bool cancellationResult;
        
        public doCancelRefundFormResponse()
        {
        }
        
        public doCancelRefundFormResponse(bool cancellationResult)
        {
            this.cancellationResult = cancellationResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoCancelRefundWarningRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doCancelRefundWarningRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public int refundId;
        
        public doCancelRefundWarningRequest()
        {
        }
        
        public doCancelRefundWarningRequest(string sessionId, int refundId)
        {
            this.sessionId = sessionId;
            this.refundId = refundId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doCancelRefundWarningResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doCancelRefundWarningResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public bool cancellationResult;
        
        public doCancelRefundWarningResponse()
        {
        }
        
        public doCancelRefundWarningResponse(bool cancellationResult)
        {
            this.cancellationResult = cancellationResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoCancelTransactionRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doCancelTransactionRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long transactionId;
        
        public doCancelTransactionRequest()
        {
        }
        
        public doCancelTransactionRequest(string sessionId, long transactionId)
        {
            this.sessionId = sessionId;
            this.transactionId = transactionId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doCancelTransactionResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doCancelTransactionResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int cancellationResult;
        
        public doCancelTransactionResponse()
        {
        }
        
        public doCancelTransactionResponse(int cancellationResult)
        {
            this.cancellationResult = cancellationResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoChangeItemFieldsRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doChangeItemFieldsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long itemId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.FieldsValue[] fieldsToModify;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public int[] fieldsToRemove;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public int previewOnly;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.VariantStruct[] variants;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=6)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.TagNameStruct[] tags;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=7)]
        public Allegro.AfterSalesServiceConditionsStruct afterSalesServiceConditions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=8)]
        public string additionalServicesGroup;
        
        public doChangeItemFieldsRequest()
        {
        }
        
        public doChangeItemFieldsRequest(string sessionId, long itemId, Allegro.FieldsValue[] fieldsToModify, int[] fieldsToRemove, int previewOnly, Allegro.VariantStruct[] variants, Allegro.TagNameStruct[] tags, Allegro.AfterSalesServiceConditionsStruct afterSalesServiceConditions, string additionalServicesGroup)
        {
            this.sessionId = sessionId;
            this.itemId = itemId;
            this.fieldsToModify = fieldsToModify;
            this.fieldsToRemove = fieldsToRemove;
            this.previewOnly = previewOnly;
            this.variants = variants;
            this.tags = tags;
            this.afterSalesServiceConditions = afterSalesServiceConditions;
            this.additionalServicesGroup = additionalServicesGroup;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doChangeItemFieldsResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doChangeItemFieldsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public Allegro.ChangedItemStruct changedItem;
        
        public doChangeItemFieldsResponse()
        {
        }
        
        public doChangeItemFieldsResponse(Allegro.ChangedItemStruct changedItem)
        {
            this.changedItem = changedItem;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoChangePriceItemRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doChangePriceItemRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long itemId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public float newStartingPrice;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public float newReservePrice;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public float newBuyNowPrice;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=5)]
        public float newAdvertisementPrice;
        
        public doChangePriceItemRequest()
        {
        }
        
        public doChangePriceItemRequest(string sessionHandle, long itemId, float newStartingPrice, float newReservePrice, float newBuyNowPrice, float newAdvertisementPrice)
        {
            this.sessionHandle = sessionHandle;
            this.itemId = itemId;
            this.newStartingPrice = newStartingPrice;
            this.newReservePrice = newReservePrice;
            this.newBuyNowPrice = newBuyNowPrice;
            this.newAdvertisementPrice = newAdvertisementPrice;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doChangePriceItemResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doChangePriceItemResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string itemInfo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long itemId;
        
        public doChangePriceItemResponse()
        {
        }
        
        public doChangePriceItemResponse(string itemInfo, long itemId)
        {
            this.itemInfo = itemInfo;
            this.itemId = itemId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoChangeQuantityItemRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doChangeQuantityItemRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long itemId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public int newItemQuantity;
        
        public doChangeQuantityItemRequest()
        {
        }
        
        public doChangeQuantityItemRequest(string sessionHandle, long itemId, int newItemQuantity)
        {
            this.sessionHandle = sessionHandle;
            this.itemId = itemId;
            this.newItemQuantity = newItemQuantity;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doChangeQuantityItemResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doChangeQuantityItemResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public long itemId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public string itemInfo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public int itemQuantityLeft;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public int itemQuantitySold;
        
        public doChangeQuantityItemResponse()
        {
        }
        
        public doChangeQuantityItemResponse(long itemId, string itemInfo, int itemQuantityLeft, int itemQuantitySold)
        {
            this.itemId = itemId;
            this.itemInfo = itemInfo;
            this.itemQuantityLeft = itemQuantityLeft;
            this.itemQuantitySold = itemQuantitySold;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoCheckItemDescriptionRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doCheckItemDescriptionRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public string descriptionContent;
        
        public doCheckItemDescriptionRequest()
        {
        }
        
        public doCheckItemDescriptionRequest(string sessionId, string descriptionContent)
        {
            this.sessionId = sessionId;
            this.descriptionContent = descriptionContent;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doCheckItemDescriptionResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doCheckItemDescriptionResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public Allegro.ItemDescriptionStruct itemDescription;
        
        public doCheckItemDescriptionResponse()
        {
        }
        
        public doCheckItemDescriptionResponse(Allegro.ItemDescriptionStruct itemDescription)
        {
            this.itemDescription = itemDescription;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoCheckNewAuctionExtRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doCheckNewAuctionExtRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.FieldsValue[] fields;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.VariantStruct[] variants;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.TagNameStruct[] tags;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public Allegro.AfterSalesServiceConditionsStruct afterSalesServiceConditions;
        
        public doCheckNewAuctionExtRequest()
        {
        }
        
        public doCheckNewAuctionExtRequest(string sessionHandle, Allegro.FieldsValue[] fields, Allegro.VariantStruct[] variants, Allegro.TagNameStruct[] tags, Allegro.AfterSalesServiceConditionsStruct afterSalesServiceConditions)
        {
            this.sessionHandle = sessionHandle;
            this.fields = fields;
            this.variants = variants;
            this.tags = tags;
            this.afterSalesServiceConditions = afterSalesServiceConditions;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doCheckNewAuctionExtResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doCheckNewAuctionExtResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string itemPrice;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public string itemPriceDesc;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public int itemIsAllegroStandard;
        
        public doCheckNewAuctionExtResponse()
        {
        }
        
        public doCheckNewAuctionExtResponse(string itemPrice, string itemPriceDesc, int itemIsAllegroStandard)
        {
            this.itemPrice = itemPrice;
            this.itemPriceDesc = itemPriceDesc;
            this.itemIsAllegroStandard = itemIsAllegroStandard;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoFinishItemRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doFinishItemRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long finishItemId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public int finishCancelAllBids;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public string finishCancelReason;
        
        public doFinishItemRequest()
        {
        }
        
        public doFinishItemRequest(string sessionHandle, long finishItemId, int finishCancelAllBids, string finishCancelReason)
        {
            this.sessionHandle = sessionHandle;
            this.finishItemId = finishItemId;
            this.finishCancelAllBids = finishCancelAllBids;
            this.finishCancelReason = finishCancelReason;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doFinishItemResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doFinishItemResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int finishValue;
        
        public doFinishItemResponse()
        {
        }
        
        public doFinishItemResponse(int finishValue)
        {
            this.finishValue = finishValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoFinishItemsRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doFinishItemsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.FinishItemsStruct[] finishItemsList;
        
        public doFinishItemsRequest()
        {
        }
        
        public doFinishItemsRequest(string sessionHandle, Allegro.FinishItemsStruct[] finishItemsList)
        {
            this.sessionHandle = sessionHandle;
            this.finishItemsList = finishItemsList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doFinishItemsResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doFinishItemsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] finishItemsSucceed;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.FinishFailureStruct[] finishItemsFailed;
        
        public doFinishItemsResponse()
        {
        }
        
        public doFinishItemsResponse(long[] finishItemsSucceed, Allegro.FinishFailureStruct[] finishItemsFailed)
        {
            this.finishItemsSucceed = finishItemsSucceed;
            this.finishItemsFailed = finishItemsFailed;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetArchiveRefundsListRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetArchiveRefundsListRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long itemId;
        
        public doGetArchiveRefundsListRequest()
        {
        }
        
        public doGetArchiveRefundsListRequest(string sessionId, long itemId)
        {
            this.sessionId = sessionId;
            this.itemId = itemId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetArchiveRefundsListResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetArchiveRefundsListResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int refundsCount;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.ArchiveRefundsListTypeStruct[] refundsList;
        
        public doGetArchiveRefundsListResponse()
        {
        }
        
        public doGetArchiveRefundsListResponse(int refundsCount, Allegro.ArchiveRefundsListTypeStruct[] refundsList)
        {
            this.refundsCount = refundsCount;
            this.refundsList = refundsList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetBidItem2Request", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetBidItem2Request
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long itemId;
        
        public doGetBidItem2Request()
        {
        }
        
        public doGetBidItem2Request(string sessionHandle, long itemId)
        {
            this.sessionHandle = sessionHandle;
            this.itemId = itemId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetBidItem2Response", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetBidItem2Response
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.BidListStruct2[] biditemList;
        
        public doGetBidItem2Response()
        {
        }
        
        public doGetBidItem2Response(Allegro.BidListStruct2[] biditemList)
        {
            this.biditemList = biditemList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetBlackListUsersRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetBlackListUsersRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        public doGetBlackListUsersRequest()
        {
        }
        
        public doGetBlackListUsersRequest(string sessionHandle)
        {
            this.sessionHandle = sessionHandle;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetBlackListUsersResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetBlackListUsersResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.BlackListStruct[] blackListUsers;
        
        public doGetBlackListUsersResponse()
        {
        }
        
        public doGetBlackListUsersResponse(Allegro.BlackListStruct[] blackListUsers)
        {
            this.blackListUsers = blackListUsers;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetCategoryPathRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetCategoryPathRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public int categoryId;
        
        public doGetCategoryPathRequest()
        {
        }
        
        public doGetCategoryPathRequest(string sessionId, int categoryId)
        {
            this.sessionId = sessionId;
            this.categoryId = categoryId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetCategoryPathResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetCategoryPathResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.CategoryData[] categoryPath;
        
        public doGetCategoryPathResponse()
        {
        }
        
        public doGetCategoryPathResponse(Allegro.CategoryData[] categoryPath)
        {
            this.categoryPath = categoryPath;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetCatsDataRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetCatsDataRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int countryId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long localVersion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public string webapiKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public bool onlyLeaf;
        
        public doGetCatsDataRequest()
        {
        }
        
        public doGetCatsDataRequest(int countryId, long localVersion, string webapiKey, bool onlyLeaf)
        {
            this.countryId = countryId;
            this.localVersion = localVersion;
            this.webapiKey = webapiKey;
            this.onlyLeaf = onlyLeaf;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetCatsDataResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetCatsDataResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.CatInfoType[] catsList;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long verKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public string verStr;
        
        public doGetCatsDataResponse()
        {
        }
        
        public doGetCatsDataResponse(Allegro.CatInfoType[] catsList, long verKey, string verStr)
        {
            this.catsList = catsList;
            this.verKey = verKey;
            this.verStr = verStr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetCatsDataCountRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetCatsDataCountRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int countryId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long localVersion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public string webapiKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public bool onlyLeaf;
        
        public doGetCatsDataCountRequest()
        {
        }
        
        public doGetCatsDataCountRequest(int countryId, long localVersion, string webapiKey, bool onlyLeaf)
        {
            this.countryId = countryId;
            this.localVersion = localVersion;
            this.webapiKey = webapiKey;
            this.onlyLeaf = onlyLeaf;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetCatsDataCountResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetCatsDataCountResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int catsCount;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long verKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public string verStr;
        
        public doGetCatsDataCountResponse()
        {
        }
        
        public doGetCatsDataCountResponse(int catsCount, long verKey, string verStr)
        {
            this.catsCount = catsCount;
            this.verKey = verKey;
            this.verStr = verStr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetCatsDataLimitRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetCatsDataLimitRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int countryId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long localVersion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public string webapiKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public int offset;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public int packageElement;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=5)]
        public bool onlyLeaf;
        
        public doGetCatsDataLimitRequest()
        {
        }
        
        public doGetCatsDataLimitRequest(int countryId, long localVersion, string webapiKey, int offset, int packageElement, bool onlyLeaf)
        {
            this.countryId = countryId;
            this.localVersion = localVersion;
            this.webapiKey = webapiKey;
            this.offset = offset;
            this.packageElement = packageElement;
            this.onlyLeaf = onlyLeaf;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetCatsDataLimitResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetCatsDataLimitResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.CatInfoType[] catsList;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long verKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public string verStr;
        
        public doGetCatsDataLimitResponse()
        {
        }
        
        public doGetCatsDataLimitResponse(Allegro.CatInfoType[] catsList, long verKey, string verStr)
        {
            this.catsList = catsList;
            this.verKey = verKey;
            this.verStr = verStr;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetCountriesRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetCountriesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int countryCode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public string webapiKey;
        
        public doGetCountriesRequest()
        {
        }
        
        public doGetCountriesRequest(int countryCode, string webapiKey)
        {
            this.countryCode = countryCode;
            this.webapiKey = webapiKey;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetCountriesResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetCountriesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.CountryInfoType[] countryArray;
        
        public doGetCountriesResponse()
        {
        }
        
        public doGetCountriesResponse(Allegro.CountryInfoType[] countryArray)
        {
            this.countryArray = countryArray;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetDealsRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetDealsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long itemId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public int buyerId;
        
        public doGetDealsRequest()
        {
        }
        
        public doGetDealsRequest(string sessionHandle, long itemId, int buyerId)
        {
            this.sessionHandle = sessionHandle;
            this.itemId = itemId;
            this.buyerId = buyerId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetDealsResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetDealsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.DealsStruct[] dealsList;
        
        public doGetDealsResponse()
        {
        }
        
        public doGetDealsResponse(Allegro.DealsStruct[] dealsList)
        {
            this.dealsList = dealsList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetFilledPostBuyFormsRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetFilledPostBuyFormsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public int paymentType;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public int userRole;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public long fillingTimeFrom;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public long fillingTimeTo;
        
        public doGetFilledPostBuyFormsRequest()
        {
        }
        
        public doGetFilledPostBuyFormsRequest(string sessionId, int paymentType, int userRole, long fillingTimeFrom, long fillingTimeTo)
        {
            this.sessionId = sessionId;
            this.paymentType = paymentType;
            this.userRole = userRole;
            this.fillingTimeFrom = fillingTimeFrom;
            this.fillingTimeTo = fillingTimeTo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetFilledPostBuyFormsResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetFilledPostBuyFormsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public Allegro.FilledPostBuyFormsStruct filledPostBuyForms;
        
        public doGetFilledPostBuyFormsResponse()
        {
        }
        
        public doGetFilledPostBuyFormsResponse(Allegro.FilledPostBuyFormsStruct filledPostBuyForms)
        {
            this.filledPostBuyForms = filledPostBuyForms;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetFreeDeliveryAmountRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetFreeDeliveryAmountRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int userId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public int countryId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public string webapiKey;
        
        public doGetFreeDeliveryAmountRequest()
        {
        }
        
        public doGetFreeDeliveryAmountRequest(int userId, int countryId, string webapiKey)
        {
            this.userId = userId;
            this.countryId = countryId;
            this.webapiKey = webapiKey;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetFreeDeliveryAmountResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetFreeDeliveryAmountResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public float freeDeliveryAmount;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public int activeFlag;
        
        public doGetFreeDeliveryAmountResponse()
        {
        }
        
        public doGetFreeDeliveryAmountResponse(float freeDeliveryAmount, int activeFlag)
        {
            this.freeDeliveryAmount = freeDeliveryAmount;
            this.activeFlag = activeFlag;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetItemFieldsRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetItemFieldsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long itemId;
        
        public doGetItemFieldsRequest()
        {
        }
        
        public doGetItemFieldsRequest(string sessionId, long itemId)
        {
            this.sessionId = sessionId;
            this.itemId = itemId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetItemFieldsResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetItemFieldsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.FieldsValue[] itemFields;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public Allegro.AfterSalesServiceConditionsStruct afterSalesServiceConditions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public string additionalServicesGroup;
        
        public doGetItemFieldsResponse()
        {
        }
        
        public doGetItemFieldsResponse(Allegro.FieldsValue[] itemFields, Allegro.AfterSalesServiceConditionsStruct afterSalesServiceConditions, string additionalServicesGroup)
        {
            this.itemFields = itemFields;
            this.afterSalesServiceConditions = afterSalesServiceConditions;
            this.additionalServicesGroup = additionalServicesGroup;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetItemsImagesRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetItemsImagesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.ItemGetImage[] itemsArray;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public int imageType;
        
        public doGetItemsImagesRequest()
        {
        }
        
        public doGetItemsImagesRequest(string sessionHandle, Allegro.ItemGetImage[] itemsArray, int imageType)
        {
            this.sessionHandle = sessionHandle;
            this.itemsArray = itemsArray;
            this.imageType = imageType;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetItemsImagesResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetItemsImagesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.ItemImagesStruct[] get_items_images_result;
        
        public doGetItemsImagesResponse()
        {
        }
        
        public doGetItemsImagesResponse(Allegro.ItemImagesStruct[] get_items_images_result)
        {
            this.get_items_images_result = get_items_images_result;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetItemsInfoRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetItemsInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] itemsIdArray;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public int getDesc;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public int getImageUrl;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public int getAttribs;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=5)]
        public int getPostageOptions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=6)]
        public int getCompanyInfo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=7)]
        public int getProductInfo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=8)]
        public int getAfterSalesServiceConditions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=9)]
        public int getEan;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=10)]
        public int getAdditionalServicesGroup;
        
        public doGetItemsInfoRequest()
        {
        }
        
        public doGetItemsInfoRequest(string sessionHandle, long[] itemsIdArray, int getDesc, int getImageUrl, int getAttribs, int getPostageOptions, int getCompanyInfo, int getProductInfo, int getAfterSalesServiceConditions, int getEan, int getAdditionalServicesGroup)
        {
            this.sessionHandle = sessionHandle;
            this.itemsIdArray = itemsIdArray;
            this.getDesc = getDesc;
            this.getImageUrl = getImageUrl;
            this.getAttribs = getAttribs;
            this.getPostageOptions = getPostageOptions;
            this.getCompanyInfo = getCompanyInfo;
            this.getProductInfo = getProductInfo;
            this.getAfterSalesServiceConditions = getAfterSalesServiceConditions;
            this.getEan = getEan;
            this.getAdditionalServicesGroup = getAdditionalServicesGroup;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetItemsInfoResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetItemsInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.ItemInfoStruct[] arrayItemListInfo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] arrayItemsNotFound;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] arrayItemsAdminKilled;
        
        public doGetItemsInfoResponse()
        {
        }
        
        public doGetItemsInfoResponse(Allegro.ItemInfoStruct[] arrayItemListInfo, long[] arrayItemsNotFound, long[] arrayItemsAdminKilled)
        {
            this.arrayItemListInfo = arrayItemListInfo;
            this.arrayItemsNotFound = arrayItemsNotFound;
            this.arrayItemsAdminKilled = arrayItemsAdminKilled;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetItemsListRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetItemsListRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string webapiKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public int countryId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.FilterOptionsType[] filterOptions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public Allegro.SortOptionsType sortOptions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public int resultSize;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=5)]
        public int resultOffset;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=6)]
        public int resultScope;
        
        public doGetItemsListRequest()
        {
        }
        
        public doGetItemsListRequest(string webapiKey, int countryId, Allegro.FilterOptionsType[] filterOptions, Allegro.SortOptionsType sortOptions, int resultSize, int resultOffset, int resultScope)
        {
            this.webapiKey = webapiKey;
            this.countryId = countryId;
            this.filterOptions = filterOptions;
            this.sortOptions = sortOptions;
            this.resultSize = resultSize;
            this.resultOffset = resultOffset;
            this.resultScope = resultScope;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetItemsListResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetItemsListResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int itemsCount;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public int itemsFeaturedCount;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.ItemsListType[] itemsList;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public Allegro.CategoriesListType categoriesList;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.FiltersListType[] filtersList;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public string[] filtersRejected;
        
        public doGetItemsListResponse()
        {
        }
        
        public doGetItemsListResponse(int itemsCount, int itemsFeaturedCount, Allegro.ItemsListType[] itemsList, Allegro.CategoriesListType categoriesList, Allegro.FiltersListType[] filtersList, string[] filtersRejected)
        {
            this.itemsCount = itemsCount;
            this.itemsFeaturedCount = itemsFeaturedCount;
            this.itemsList = itemsList;
            this.categoriesList = categoriesList;
            this.filtersList = filtersList;
            this.filtersRejected = filtersRejected;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetMessageToBuyerRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMessageToBuyerRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long itemId;
        
        public doGetMessageToBuyerRequest()
        {
        }
        
        public doGetMessageToBuyerRequest(string sessionId, long itemId)
        {
            this.sessionId = sessionId;
            this.itemId = itemId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetMessageToBuyerResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMessageToBuyerResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public Allegro.MessageToBuyerStruct messageToBuyer;
        
        public doGetMessageToBuyerResponse()
        {
        }
        
        public doGetMessageToBuyerResponse(Allegro.MessageToBuyerStruct messageToBuyer)
        {
            this.messageToBuyer = messageToBuyer;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetMyAddressesRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyAddressesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        public doGetMyAddressesRequest()
        {
        }
        
        public doGetMyAddressesRequest(string sessionId)
        {
            this.sessionId = sessionId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetMyAddressesResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyAddressesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.AddressInfoStruct[] addressesInfo;
        
        public doGetMyAddressesResponse()
        {
        }
        
        public doGetMyAddressesResponse(Allegro.AddressInfoStruct[] addressesInfo)
        {
            this.addressesInfo = addressesInfo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetMyBidItemsRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyBidItemsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public Allegro.SortOptionsStruct sortOptions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public string searchValue;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public int categoryId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] itemIds;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=5)]
        public int pageSize;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=6)]
        public int pageNumber;
        
        public doGetMyBidItemsRequest()
        {
        }
        
        public doGetMyBidItemsRequest(string sessionId, Allegro.SortOptionsStruct sortOptions, string searchValue, int categoryId, long[] itemIds, int pageSize, int pageNumber)
        {
            this.sessionId = sessionId;
            this.sortOptions = sortOptions;
            this.searchValue = searchValue;
            this.categoryId = categoryId;
            this.itemIds = itemIds;
            this.pageSize = pageSize;
            this.pageNumber = pageNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetMyBidItemsResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyBidItemsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int bidItemsCounter;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.BidItemStruct[] bidItemsList;
        
        public doGetMyBidItemsResponse()
        {
        }
        
        public doGetMyBidItemsResponse(int bidItemsCounter, Allegro.BidItemStruct[] bidItemsList)
        {
            this.bidItemsCounter = bidItemsCounter;
            this.bidItemsList = bidItemsList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetMyCurrentShipmentPriceTypeRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyCurrentShipmentPriceTypeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        public doGetMyCurrentShipmentPriceTypeRequest()
        {
        }
        
        public doGetMyCurrentShipmentPriceTypeRequest(string sessionId)
        {
            this.sessionId = sessionId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetMyCurrentShipmentPriceTypeResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyCurrentShipmentPriceTypeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int shipmentPriceTypeId;
        
        public doGetMyCurrentShipmentPriceTypeResponse()
        {
        }
        
        public doGetMyCurrentShipmentPriceTypeResponse(int shipmentPriceTypeId)
        {
            this.shipmentPriceTypeId = shipmentPriceTypeId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetMyDataRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyDataRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        public doGetMyDataRequest()
        {
        }
        
        public doGetMyDataRequest(string sessionHandle)
        {
            this.sessionHandle = sessionHandle;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetMyDataResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyDataResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public Allegro.UserDataStruct userData;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public Allegro.InvoiceDataStruct invoiceData;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public Allegro.CompanyExtraDataStruct companyExtraData;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public Allegro.CompanySecondAddressStruct companySecondAddress;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public Allegro.PharmacyDataStruct pharmacyData;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=5)]
        public Allegro.AlcoholDataStruct alcoholData;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=6)]
        public Allegro.RelatedPersonsStruct relatedPersons;
        
        public doGetMyDataResponse()
        {
        }
        
        public doGetMyDataResponse(Allegro.UserDataStruct userData, Allegro.InvoiceDataStruct invoiceData, Allegro.CompanyExtraDataStruct companyExtraData, Allegro.CompanySecondAddressStruct companySecondAddress, Allegro.PharmacyDataStruct pharmacyData, Allegro.AlcoholDataStruct alcoholData, Allegro.RelatedPersonsStruct relatedPersons)
        {
            this.userData = userData;
            this.invoiceData = invoiceData;
            this.companyExtraData = companyExtraData;
            this.companySecondAddress = companySecondAddress;
            this.pharmacyData = pharmacyData;
            this.alcoholData = alcoholData;
            this.relatedPersons = relatedPersons;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetMyFutureItemsRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyFutureItemsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public Allegro.SortOptionsStruct sortOptions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public Allegro.FutureFilterOptionsStruct filterOptions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public int categoryId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] itemIds;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=5)]
        public int pageSize;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=6)]
        public int pageNumber;
        
        public doGetMyFutureItemsRequest()
        {
        }
        
        public doGetMyFutureItemsRequest(string sessionId, Allegro.SortOptionsStruct sortOptions, Allegro.FutureFilterOptionsStruct filterOptions, int categoryId, long[] itemIds, int pageSize, int pageNumber)
        {
            this.sessionId = sessionId;
            this.sortOptions = sortOptions;
            this.filterOptions = filterOptions;
            this.categoryId = categoryId;
            this.itemIds = itemIds;
            this.pageSize = pageSize;
            this.pageNumber = pageNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetMyFutureItemsResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyFutureItemsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int futureItemsCounter;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.FutureItemStruct[] futureItemsList;
        
        public doGetMyFutureItemsResponse()
        {
        }
        
        public doGetMyFutureItemsResponse(int futureItemsCounter, Allegro.FutureItemStruct[] futureItemsList)
        {
            this.futureItemsCounter = futureItemsCounter;
            this.futureItemsList = futureItemsList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetMyIncomingPaymentsRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyIncomingPaymentsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public int buyerId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public long itemId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public long transRecvDateFrom;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public long transRecvDateTo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=5)]
        public int transPageLimit;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=6)]
        public int transOffset;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=7)]
        public int strictedSearch;
        
        public doGetMyIncomingPaymentsRequest()
        {
        }
        
        public doGetMyIncomingPaymentsRequest(string sessionHandle, int buyerId, long itemId, long transRecvDateFrom, long transRecvDateTo, int transPageLimit, int transOffset, int strictedSearch)
        {
            this.sessionHandle = sessionHandle;
            this.buyerId = buyerId;
            this.itemId = itemId;
            this.transRecvDateFrom = transRecvDateFrom;
            this.transRecvDateTo = transRecvDateTo;
            this.transPageLimit = transPageLimit;
            this.transOffset = transOffset;
            this.strictedSearch = strictedSearch;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetMyIncomingPaymentsResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyIncomingPaymentsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.UserIncomingPaymentStruct[] payTransIncome;
        
        public doGetMyIncomingPaymentsResponse()
        {
        }
        
        public doGetMyIncomingPaymentsResponse(Allegro.UserIncomingPaymentStruct[] payTransIncome)
        {
            this.payTransIncome = payTransIncome;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetMyIncomingPaymentsRefundsRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyIncomingPaymentsRefundsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public int buyerId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public long itemId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public int limit;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public int offset;
        
        public doGetMyIncomingPaymentsRefundsRequest()
        {
        }
        
        public doGetMyIncomingPaymentsRefundsRequest(string sessionHandle, int buyerId, long itemId, int limit, int offset)
        {
            this.sessionHandle = sessionHandle;
            this.buyerId = buyerId;
            this.itemId = itemId;
            this.limit = limit;
            this.offset = offset;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetMyIncomingPaymentsRefundsResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyIncomingPaymentsRefundsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.UserIncomingPaymentRefundsStruct[] payTransIncomeRefunds;
        
        public doGetMyIncomingPaymentsRefundsResponse()
        {
        }
        
        public doGetMyIncomingPaymentsRefundsResponse(Allegro.UserIncomingPaymentRefundsStruct[] payTransIncomeRefunds)
        {
            this.payTransIncomeRefunds = payTransIncomeRefunds;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetMyNotSoldItemsRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyNotSoldItemsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public Allegro.SortOptionsStruct sortOptions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public Allegro.NotSoldFilterOptionsStruct filterOptions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public string searchValue;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public int categoryId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] itemIds;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=6)]
        public int pageSize;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=7)]
        public int pageNumber;
        
        public doGetMyNotSoldItemsRequest()
        {
        }
        
        public doGetMyNotSoldItemsRequest(string sessionId, Allegro.SortOptionsStruct sortOptions, Allegro.NotSoldFilterOptionsStruct filterOptions, string searchValue, int categoryId, long[] itemIds, int pageSize, int pageNumber)
        {
            this.sessionId = sessionId;
            this.sortOptions = sortOptions;
            this.filterOptions = filterOptions;
            this.searchValue = searchValue;
            this.categoryId = categoryId;
            this.itemIds = itemIds;
            this.pageSize = pageSize;
            this.pageNumber = pageNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetMyNotSoldItemsResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyNotSoldItemsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int notSoldItemsCounter;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.NotSoldItemStruct[] notSoldItemsList;
        
        public doGetMyNotSoldItemsResponse()
        {
        }
        
        public doGetMyNotSoldItemsResponse(int notSoldItemsCounter, Allegro.NotSoldItemStruct[] notSoldItemsList)
        {
            this.notSoldItemsCounter = notSoldItemsCounter;
            this.notSoldItemsList = notSoldItemsList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetMyNotWonItemsRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyNotWonItemsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public Allegro.SortOptionsStruct sortOptions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public string searchValue;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public int categoryId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] itemIds;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=5)]
        public int pageSize;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=6)]
        public int pageNumber;
        
        public doGetMyNotWonItemsRequest()
        {
        }
        
        public doGetMyNotWonItemsRequest(string sessionId, Allegro.SortOptionsStruct sortOptions, string searchValue, int categoryId, long[] itemIds, int pageSize, int pageNumber)
        {
            this.sessionId = sessionId;
            this.sortOptions = sortOptions;
            this.searchValue = searchValue;
            this.categoryId = categoryId;
            this.itemIds = itemIds;
            this.pageSize = pageSize;
            this.pageNumber = pageNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetMyNotWonItemsResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyNotWonItemsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int notWonItemsCounter;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.NotWonItemStruct[] notWonItemsList;
        
        public doGetMyNotWonItemsResponse()
        {
        }
        
        public doGetMyNotWonItemsResponse(int notWonItemsCounter, Allegro.NotWonItemStruct[] notWonItemsList)
        {
            this.notWonItemsCounter = notWonItemsCounter;
            this.notWonItemsList = notWonItemsList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetMyPaymentsRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyPaymentsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public int sellerId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public long itemId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public long paymentTimeFrom;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public long paymentTimeTo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=5)]
        public int pageSize;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=6)]
        public int pageNumber;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=7)]
        public int strictedSearch;
        
        public doGetMyPaymentsRequest()
        {
        }
        
        public doGetMyPaymentsRequest(string sessionId, int sellerId, long itemId, long paymentTimeFrom, long paymentTimeTo, int pageSize, int pageNumber, int strictedSearch)
        {
            this.sessionId = sessionId;
            this.sellerId = sellerId;
            this.itemId = itemId;
            this.paymentTimeFrom = paymentTimeFrom;
            this.paymentTimeTo = paymentTimeTo;
            this.pageSize = pageSize;
            this.pageNumber = pageNumber;
            this.strictedSearch = strictedSearch;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetMyPaymentsResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyPaymentsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.UserPaymentStruct[] payTransPayment;
        
        public doGetMyPaymentsResponse()
        {
        }
        
        public doGetMyPaymentsResponse(Allegro.UserPaymentStruct[] payTransPayment)
        {
            this.payTransPayment = payTransPayment;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetMyPaymentsInfoRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyPaymentsInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        public doGetMyPaymentsInfoRequest()
        {
        }
        
        public doGetMyPaymentsInfoRequest(string sessionId)
        {
            this.sessionId = sessionId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetMyPaymentsInfoResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyPaymentsInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public Allegro.PaymentsInfoStruct paymentsInfo;
        
        public doGetMyPaymentsInfoResponse()
        {
        }
        
        public doGetMyPaymentsInfoResponse(Allegro.PaymentsInfoStruct paymentsInfo)
        {
            this.paymentsInfo = paymentsInfo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetMyPaymentsRefundsRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyPaymentsRefundsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public int sellerId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public long itemId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public int limit;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public int offset;
        
        public doGetMyPaymentsRefundsRequest()
        {
        }
        
        public doGetMyPaymentsRefundsRequest(string sessionHandle, int sellerId, long itemId, int limit, int offset)
        {
            this.sessionHandle = sessionHandle;
            this.sellerId = sellerId;
            this.itemId = itemId;
            this.limit = limit;
            this.offset = offset;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetMyPaymentsRefundsResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyPaymentsRefundsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.UserPaymentRefundsStruct[] payTransPaymentRefunds;
        
        public doGetMyPaymentsRefundsResponse()
        {
        }
        
        public doGetMyPaymentsRefundsResponse(Allegro.UserPaymentRefundsStruct[] payTransPaymentRefunds)
        {
            this.payTransPaymentRefunds = payTransPaymentRefunds;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetMyPayoutsRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyPayoutsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long transCreateDateFrom;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public long transCreateDateTo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public int transPageLimit;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public int transOffset;
        
        public doGetMyPayoutsRequest()
        {
        }
        
        public doGetMyPayoutsRequest(string sessionHandle, long transCreateDateFrom, long transCreateDateTo, int transPageLimit, int transOffset)
        {
            this.sessionHandle = sessionHandle;
            this.transCreateDateFrom = transCreateDateFrom;
            this.transCreateDateTo = transCreateDateTo;
            this.transPageLimit = transPageLimit;
            this.transOffset = transOffset;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetMyPayoutsResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyPayoutsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.UserPayoutStruct[] payTransPayout;
        
        public doGetMyPayoutsResponse()
        {
        }
        
        public doGetMyPayoutsResponse(Allegro.UserPayoutStruct[] payTransPayout)
        {
            this.payTransPayout = payTransPayout;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetMyPayoutsDetailsRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyPayoutsDetailsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public int payoutId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public int limit;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public int offset;
        
        public doGetMyPayoutsDetailsRequest()
        {
        }
        
        public doGetMyPayoutsDetailsRequest(string sessionId, int payoutId, int limit, int offset)
        {
            this.sessionId = sessionId;
            this.payoutId = payoutId;
            this.limit = limit;
            this.offset = offset;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetMyPayoutsDetailsResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyPayoutsDetailsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int paymentsCount;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.PayoutPaymentsStruct[] payments;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public int refundsFromCount;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.PayoutRefundFromStruct[] refundFrom;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public int refundsToCount;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.PayoutRefundToStruct[] refundTo;
        
        public doGetMyPayoutsDetailsResponse()
        {
        }
        
        public doGetMyPayoutsDetailsResponse(int paymentsCount, Allegro.PayoutPaymentsStruct[] payments, int refundsFromCount, Allegro.PayoutRefundFromStruct[] refundFrom, int refundsToCount, Allegro.PayoutRefundToStruct[] refundTo)
        {
            this.paymentsCount = paymentsCount;
            this.payments = payments;
            this.refundsFromCount = refundsFromCount;
            this.refundFrom = refundFrom;
            this.refundsToCount = refundsToCount;
            this.refundTo = refundTo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetMySellItemsRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMySellItemsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public Allegro.SortOptionsStruct sortOptions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public Allegro.SellFilterOptionsStruct filterOptions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public string searchValue;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public int categoryId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] itemIds;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=6)]
        public int pageSize;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=7)]
        public int pageNumber;
        
        public doGetMySellItemsRequest()
        {
        }
        
        public doGetMySellItemsRequest(string sessionId, Allegro.SortOptionsStruct sortOptions, Allegro.SellFilterOptionsStruct filterOptions, string searchValue, int categoryId, long[] itemIds, int pageSize, int pageNumber)
        {
            this.sessionId = sessionId;
            this.sortOptions = sortOptions;
            this.filterOptions = filterOptions;
            this.searchValue = searchValue;
            this.categoryId = categoryId;
            this.itemIds = itemIds;
            this.pageSize = pageSize;
            this.pageNumber = pageNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetMySellItemsResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMySellItemsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int sellItemsCounter;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.SellItemStruct[] sellItemsList;
        
        public doGetMySellItemsResponse()
        {
        }
        
        public doGetMySellItemsResponse(int sellItemsCounter, Allegro.SellItemStruct[] sellItemsList)
        {
            this.sellItemsCounter = sellItemsCounter;
            this.sellItemsList = sellItemsList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetMySoldItemsRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMySoldItemsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public Allegro.SortOptionsStruct sortOptions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public Allegro.SoldFilterOptionsStruct filterOptions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public string searchValue;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public int categoryId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] itemIds;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=6)]
        public int pageSize;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=7)]
        public int pageNumber;
        
        public doGetMySoldItemsRequest()
        {
        }
        
        public doGetMySoldItemsRequest(string sessionId, Allegro.SortOptionsStruct sortOptions, Allegro.SoldFilterOptionsStruct filterOptions, string searchValue, int categoryId, long[] itemIds, int pageSize, int pageNumber)
        {
            this.sessionId = sessionId;
            this.sortOptions = sortOptions;
            this.filterOptions = filterOptions;
            this.searchValue = searchValue;
            this.categoryId = categoryId;
            this.itemIds = itemIds;
            this.pageSize = pageSize;
            this.pageNumber = pageNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetMySoldItemsResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMySoldItemsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int soldItemsCounter;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.SoldItemStruct[] soldItemsList;
        
        public doGetMySoldItemsResponse()
        {
        }
        
        public doGetMySoldItemsResponse(int soldItemsCounter, Allegro.SoldItemStruct[] soldItemsList)
        {
            this.soldItemsCounter = soldItemsCounter;
            this.soldItemsList = soldItemsList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetMyWonItemsRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyWonItemsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public Allegro.SortOptionsStruct sortOptions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public string searchValue;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public int categoryId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] itemIds;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=5)]
        public int pageSize;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=6)]
        public int pageNumber;
        
        public doGetMyWonItemsRequest()
        {
        }
        
        public doGetMyWonItemsRequest(string sessionId, Allegro.SortOptionsStruct sortOptions, string searchValue, int categoryId, long[] itemIds, int pageSize, int pageNumber)
        {
            this.sessionId = sessionId;
            this.sortOptions = sortOptions;
            this.searchValue = searchValue;
            this.categoryId = categoryId;
            this.itemIds = itemIds;
            this.pageSize = pageSize;
            this.pageNumber = pageNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetMyWonItemsResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetMyWonItemsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int wonItemsCounter;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.WonItemStruct[] wonItemsList;
        
        public doGetMyWonItemsResponse()
        {
        }
        
        public doGetMyWonItemsResponse(int wonItemsCounter, Allegro.WonItemStruct[] wonItemsList)
        {
            this.wonItemsCounter = wonItemsCounter;
            this.wonItemsList = wonItemsList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetPaymentMethodsRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetPaymentMethodsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] itemIds;
        
        public doGetPaymentMethodsRequest()
        {
        }
        
        public doGetPaymentMethodsRequest(string sessionId, long[] itemIds)
        {
            this.sessionId = sessionId;
            this.itemIds = itemIds;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetPaymentMethodsResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetPaymentMethodsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.PaymentMethodStruct[] paymentMethods;
        
        public doGetPaymentMethodsResponse()
        {
        }
        
        public doGetPaymentMethodsResponse(Allegro.PaymentMethodStruct[] paymentMethods)
        {
            this.paymentMethods = paymentMethods;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetPostBuyDataRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetPostBuyDataRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] itemsArray;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] buyerFilterArray;
        
        public doGetPostBuyDataRequest()
        {
        }
        
        public doGetPostBuyDataRequest(string sessionHandle, long[] itemsArray, long[] buyerFilterArray)
        {
            this.sessionHandle = sessionHandle;
            this.itemsArray = itemsArray;
            this.buyerFilterArray = buyerFilterArray;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetPostBuyDataResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetPostBuyDataResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.ItemPostBuyDataStruct[] itemsPostBuyData;
        
        public doGetPostBuyDataResponse()
        {
        }
        
        public doGetPostBuyDataResponse(Allegro.ItemPostBuyDataStruct[] itemsPostBuyData)
        {
            this.itemsPostBuyData = itemsPostBuyData;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetPostBuyFormsDataForBuyersRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetPostBuyFormsDataForBuyersRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] transactionsIdsArray;
        
        public doGetPostBuyFormsDataForBuyersRequest()
        {
        }
        
        public doGetPostBuyFormsDataForBuyersRequest(string sessionId, long[] transactionsIdsArray)
        {
            this.sessionId = sessionId;
            this.transactionsIdsArray = transactionsIdsArray;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetPostBuyFormsDataForBuyersResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetPostBuyFormsDataForBuyersResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.PostBuyFormForBuyersDataStruct[] postBuyFormDataForBuyers;
        
        public doGetPostBuyFormsDataForBuyersResponse()
        {
        }
        
        public doGetPostBuyFormsDataForBuyersResponse(Allegro.PostBuyFormForBuyersDataStruct[] postBuyFormDataForBuyers)
        {
            this.postBuyFormDataForBuyers = postBuyFormDataForBuyers;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetPostBuyFormsDataForSellersRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetPostBuyFormsDataForSellersRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] transactionsIdsArray;
        
        public doGetPostBuyFormsDataForSellersRequest()
        {
        }
        
        public doGetPostBuyFormsDataForSellersRequest(string sessionId, long[] transactionsIdsArray)
        {
            this.sessionId = sessionId;
            this.transactionsIdsArray = transactionsIdsArray;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetPostBuyFormsDataForSellersResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetPostBuyFormsDataForSellersResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.PostBuyFormDataStruct[] postBuyFormData;
        
        public doGetPostBuyFormsDataForSellersResponse()
        {
        }
        
        public doGetPostBuyFormsDataForSellersResponse(Allegro.PostBuyFormDataStruct[] postBuyFormData)
        {
            this.postBuyFormData = postBuyFormData;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetPostBuyFormsIdsRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetPostBuyFormsIdsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.FilterOptionsType[] filterOptions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public int resultSize;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public int resultOffset;
        
        public doGetPostBuyFormsIdsRequest()
        {
        }
        
        public doGetPostBuyFormsIdsRequest(string sessionId, Allegro.FilterOptionsType[] filterOptions, int resultSize, int resultOffset)
        {
            this.sessionId = sessionId;
            this.filterOptions = filterOptions;
            this.resultSize = resultSize;
            this.resultOffset = resultOffset;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetPostBuyFormsIdsResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetPostBuyFormsIdsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int formsCount;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] formsIds;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.FiltersListType[] filtersList;
        
        public doGetPostBuyFormsIdsResponse()
        {
        }
        
        public doGetPostBuyFormsIdsResponse(int formsCount, long[] formsIds, Allegro.FiltersListType[] filtersList)
        {
            this.formsCount = formsCount;
            this.formsIds = formsIds;
            this.filtersList = filtersList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetPostBuyItemInfoRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetPostBuyItemInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] itemIds;
        
        public doGetPostBuyItemInfoRequest()
        {
        }
        
        public doGetPostBuyItemInfoRequest(string sessionId, long[] itemIds)
        {
            this.sessionId = sessionId;
            this.itemIds = itemIds;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetPostBuyItemInfoResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetPostBuyItemInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.PostBuyItemInfoStruct[] itemPostBuyFormInfo;
        
        public doGetPostBuyItemInfoResponse()
        {
        }
        
        public doGetPostBuyItemInfoResponse(Allegro.PostBuyItemInfoStruct[] itemPostBuyFormInfo)
        {
            this.itemPostBuyFormInfo = itemPostBuyFormInfo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetRefundsDealsRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetRefundsDealsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.FilterOptionsType[] filterOptions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public string sortOrder;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public int resultSize;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public int resultOffset;
        
        public doGetRefundsDealsRequest()
        {
        }
        
        public doGetRefundsDealsRequest(string sessionId, Allegro.FilterOptionsType[] filterOptions, string sortOrder, int resultSize, int resultOffset)
        {
            this.sessionId = sessionId;
            this.filterOptions = filterOptions;
            this.sortOrder = sortOrder;
            this.resultSize = resultSize;
            this.resultOffset = resultOffset;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetRefundsDealsResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetRefundsDealsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int dealsCount;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.RefundsDealsListType[] dealsList;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.FiltersListType[] filtersList;
        
        public doGetRefundsDealsResponse()
        {
        }
        
        public doGetRefundsDealsResponse(int dealsCount, Allegro.RefundsDealsListType[] dealsList, Allegro.FiltersListType[] filtersList)
        {
            this.dealsCount = dealsCount;
            this.dealsList = dealsList;
            this.filtersList = filtersList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetRefundsListRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetRefundsListRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.FilterOptionsType[] filterOptions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public int resultSize;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public int resultOffset;
        
        public doGetRefundsListRequest()
        {
        }
        
        public doGetRefundsListRequest(string sessionId, Allegro.FilterOptionsType[] filterOptions, int resultSize, int resultOffset)
        {
            this.sessionId = sessionId;
            this.filterOptions = filterOptions;
            this.resultSize = resultSize;
            this.resultOffset = resultOffset;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetRefundsListResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetRefundsListResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int refundsCount;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.RefundListType[] refundsList;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.FiltersListType[] filtersList;
        
        public doGetRefundsListResponse()
        {
        }
        
        public doGetRefundsListResponse(int refundsCount, Allegro.RefundListType[] refundsList, Allegro.FiltersListType[] filtersList)
        {
            this.refundsCount = refundsCount;
            this.refundsList = refundsList;
            this.filtersList = filtersList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetRefundsReasonsRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetRefundsReasonsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public int dealId;
        
        public doGetRefundsReasonsRequest()
        {
        }
        
        public doGetRefundsReasonsRequest(string sessionId, int dealId)
        {
            this.sessionId = sessionId;
            this.dealId = dealId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetRefundsReasonsResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetRefundsReasonsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int reasonsCount;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.ReasonInfoType[] reasonsList;
        
        public doGetRefundsReasonsResponse()
        {
        }
        
        public doGetRefundsReasonsResponse(int reasonsCount, Allegro.ReasonInfoType[] reasonsList)
        {
            this.reasonsCount = reasonsCount;
            this.reasonsList = reasonsList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetRelatedItemsRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetRelatedItemsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] itemIds;
        
        public doGetRelatedItemsRequest()
        {
        }
        
        public doGetRelatedItemsRequest(string sessionId, long[] itemIds)
        {
            this.sessionId = sessionId;
            this.itemIds = itemIds;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetRelatedItemsResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetRelatedItemsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public Allegro.RelatedItemsStruct relatedItems;
        
        public doGetRelatedItemsResponse()
        {
        }
        
        public doGetRelatedItemsResponse(Allegro.RelatedItemsStruct relatedItems)
        {
            this.relatedItems = relatedItems;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetSellFormFieldsForCategoryRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetSellFormFieldsForCategoryRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string webapiKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public int countryId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public int categoryId;
        
        public doGetSellFormFieldsForCategoryRequest()
        {
        }
        
        public doGetSellFormFieldsForCategoryRequest(string webapiKey, int countryId, int categoryId)
        {
            this.webapiKey = webapiKey;
            this.countryId = countryId;
            this.categoryId = categoryId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetSellFormFieldsForCategoryResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetSellFormFieldsForCategoryResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public Allegro.SellFormFieldsForCategoryStruct sellFormFieldsForCategory;
        
        public doGetSellFormFieldsForCategoryResponse()
        {
        }
        
        public doGetSellFormFieldsForCategoryResponse(Allegro.SellFormFieldsForCategoryStruct sellFormFieldsForCategory)
        {
            this.sellFormFieldsForCategory = sellFormFieldsForCategory;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetSessionHandleForWidgetRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetSessionHandleForWidgetRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string webapiKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public int countryCode;
        
        public doGetSessionHandleForWidgetRequest()
        {
        }
        
        public doGetSessionHandleForWidgetRequest(string webapiKey, int countryCode)
        {
            this.webapiKey = webapiKey;
            this.countryCode = countryCode;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetSessionHandleForWidgetResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetSessionHandleForWidgetResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long serverTime;
        
        public doGetSessionHandleForWidgetResponse()
        {
        }
        
        public doGetSessionHandleForWidgetResponse(string sessionHandle, long serverTime)
        {
            this.sessionHandle = sessionHandle;
            this.serverTime = serverTime;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetShipmentDataRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetShipmentDataRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int countryId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public string webapiKey;
        
        public doGetShipmentDataRequest()
        {
        }
        
        public doGetShipmentDataRequest(int countryId, string webapiKey)
        {
            this.countryId = countryId;
            this.webapiKey = webapiKey;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetShipmentDataResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetShipmentDataResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.ShipmentDataStruct[] shipmentDataList;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long localVersion;
        
        public doGetShipmentDataResponse()
        {
        }
        
        public doGetShipmentDataResponse(Allegro.ShipmentDataStruct[] shipmentDataList, long localVersion)
        {
            this.shipmentDataList = shipmentDataList;
            this.localVersion = localVersion;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetShipmentDataForRelatedItemsRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetShipmentDataForRelatedItemsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] itemIds;
        
        public doGetShipmentDataForRelatedItemsRequest()
        {
        }
        
        public doGetShipmentDataForRelatedItemsRequest(string sessionId, long[] itemIds)
        {
            this.sessionId = sessionId;
            this.itemIds = itemIds;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetShipmentDataForRelatedItemsResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetShipmentDataForRelatedItemsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public Allegro.RelatedItemsShipmentDataStruct relatedItemsShipmentData;
        
        public doGetShipmentDataForRelatedItemsResponse()
        {
        }
        
        public doGetShipmentDataForRelatedItemsResponse(Allegro.RelatedItemsShipmentDataStruct relatedItemsShipmentData)
        {
            this.relatedItemsShipmentData = relatedItemsShipmentData;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetShipmentPriceTypesRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetShipmentPriceTypesRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int countryId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public string webapiKey;
        
        public doGetShipmentPriceTypesRequest()
        {
        }
        
        public doGetShipmentPriceTypesRequest(int countryId, string webapiKey)
        {
            this.countryId = countryId;
            this.webapiKey = webapiKey;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetShipmentPriceTypesResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetShipmentPriceTypesResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.ShipmentPriceTypeStruct[] shipmentPriceTypes;
        
        public doGetShipmentPriceTypesResponse()
        {
        }
        
        public doGetShipmentPriceTypesResponse(Allegro.ShipmentPriceTypeStruct[] shipmentPriceTypes)
        {
            this.shipmentPriceTypes = shipmentPriceTypes;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetShopsTagsRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetShopsTagsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        public doGetShopsTagsRequest()
        {
        }
        
        public doGetShopsTagsRequest(string sessionId)
        {
            this.sessionId = sessionId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetShopsTagsResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetShopsTagsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int shopsTagsCount;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.ShopsTagTypeStruct[] shopsTags;
        
        public doGetShopsTagsResponse()
        {
        }
        
        public doGetShopsTagsResponse(int shopsTagsCount, Allegro.ShopsTagTypeStruct[] shopsTags)
        {
            this.shopsTagsCount = shopsTagsCount;
            this.shopsTags = shopsTags;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetSiteJournalRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetSiteJournalRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long startingPoint;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public int infoType;
        
        public doGetSiteJournalRequest()
        {
        }
        
        public doGetSiteJournalRequest(string sessionHandle, long startingPoint, int infoType)
        {
            this.sessionHandle = sessionHandle;
            this.startingPoint = startingPoint;
            this.infoType = infoType;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetSiteJournalResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetSiteJournalResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.SiteJournal[] siteJournalArray;
        
        public doGetSiteJournalResponse()
        {
        }
        
        public doGetSiteJournalResponse(Allegro.SiteJournal[] siteJournalArray)
        {
            this.siteJournalArray = siteJournalArray;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetSiteJournalDealsRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetSiteJournalDealsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long journalStart;
        
        public doGetSiteJournalDealsRequest()
        {
        }
        
        public doGetSiteJournalDealsRequest(string sessionId, long journalStart)
        {
            this.sessionId = sessionId;
            this.journalStart = journalStart;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetSiteJournalDealsResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetSiteJournalDealsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.SiteJournalDealsStruct[] siteJournalDeals;
        
        public doGetSiteJournalDealsResponse()
        {
        }
        
        public doGetSiteJournalDealsResponse(Allegro.SiteJournalDealsStruct[] siteJournalDeals)
        {
            this.siteJournalDeals = siteJournalDeals;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetSiteJournalDealsInfoRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetSiteJournalDealsInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long journalStart;
        
        public doGetSiteJournalDealsInfoRequest()
        {
        }
        
        public doGetSiteJournalDealsInfoRequest(string sessionId, long journalStart)
        {
            this.sessionId = sessionId;
            this.journalStart = journalStart;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetSiteJournalDealsInfoResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetSiteJournalDealsInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public Allegro.SiteJournalDealsInfoStruct siteJournalDealsInfo;
        
        public doGetSiteJournalDealsInfoResponse()
        {
        }
        
        public doGetSiteJournalDealsInfoResponse(Allegro.SiteJournalDealsInfoStruct siteJournalDealsInfo)
        {
            this.siteJournalDealsInfo = siteJournalDealsInfo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetSiteJournalInfoRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetSiteJournalInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long startingPoint;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public int infoType;
        
        public doGetSiteJournalInfoRequest()
        {
        }
        
        public doGetSiteJournalInfoRequest(string sessionHandle, long startingPoint, int infoType)
        {
            this.sessionHandle = sessionHandle;
            this.startingPoint = startingPoint;
            this.infoType = infoType;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetSiteJournalInfoResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetSiteJournalInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public Allegro.SiteJournalInfo siteJournalInfo;
        
        public doGetSiteJournalInfoResponse()
        {
        }
        
        public doGetSiteJournalInfoResponse(Allegro.SiteJournalInfo siteJournalInfo)
        {
            this.siteJournalInfo = siteJournalInfo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetStatesInfoRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetStatesInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int countryCode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public string webapiKey;
        
        public doGetStatesInfoRequest()
        {
        }
        
        public doGetStatesInfoRequest(int countryCode, string webapiKey)
        {
            this.countryCode = countryCode;
            this.webapiKey = webapiKey;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetStatesInfoResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetStatesInfoResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.StateInfoStruct[] statesInfoArray;
        
        public doGetStatesInfoResponse()
        {
        }
        
        public doGetStatesInfoResponse(Allegro.StateInfoStruct[] statesInfoArray)
        {
            this.statesInfoArray = statesInfoArray;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetSystemTimeRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetSystemTimeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int countryId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public string webapiKey;
        
        public doGetSystemTimeRequest()
        {
        }
        
        public doGetSystemTimeRequest(int countryId, string webapiKey)
        {
            this.countryId = countryId;
            this.webapiKey = webapiKey;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetSystemTimeResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetSystemTimeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public long serverTime;
        
        public doGetSystemTimeResponse()
        {
        }
        
        public doGetSystemTimeResponse(long serverTime)
        {
            this.serverTime = serverTime;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetTransactionsIDsRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetTransactionsIDsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] itemsIdArray;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public string userRole;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] shipmentIdArray;
        
        public doGetTransactionsIDsRequest()
        {
        }
        
        public doGetTransactionsIDsRequest(string sessionHandle, long[] itemsIdArray, string userRole, long[] shipmentIdArray)
        {
            this.sessionHandle = sessionHandle;
            this.itemsIdArray = itemsIdArray;
            this.userRole = userRole;
            this.shipmentIdArray = shipmentIdArray;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetTransactionsIDsResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetTransactionsIDsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] transactionsIdsArray;
        
        public doGetTransactionsIDsResponse()
        {
        }
        
        public doGetTransactionsIDsResponse(long[] transactionsIdsArray)
        {
            this.transactionsIdsArray = transactionsIdsArray;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetUserIDRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetUserIDRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int countryId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public string userLogin;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public string userEmail;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public string webapiKey;
        
        public doGetUserIDRequest()
        {
        }
        
        public doGetUserIDRequest(int countryId, string userLogin, string userEmail, string webapiKey)
        {
            this.countryId = countryId;
            this.userLogin = userLogin;
            this.userEmail = userEmail;
            this.webapiKey = webapiKey;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetUserIDResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetUserIDResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int userId;
        
        public doGetUserIDResponse()
        {
        }
        
        public doGetUserIDResponse(int userId)
        {
            this.userId = userId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoGetUserLoginRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetUserLoginRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int countryId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public int userId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public string webapiKey;
        
        public doGetUserLoginRequest()
        {
        }
        
        public doGetUserLoginRequest(int countryId, int userId, string webapiKey)
        {
            this.countryId = countryId;
            this.userId = userId;
            this.webapiKey = webapiKey;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doGetUserLoginResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doGetUserLoginResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string userLogin;
        
        public doGetUserLoginResponse()
        {
        }
        
        public doGetUserLoginResponse(string userLogin)
        {
            this.userLogin = userLogin;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoLoginRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doLoginRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string userLogin;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public string userPassword;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public int countryCode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public string webapiKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public long localVersion;
        
        public doLoginRequest()
        {
        }
        
        public doLoginRequest(string userLogin, string userPassword, int countryCode, string webapiKey, long localVersion)
        {
            this.userLogin = userLogin;
            this.userPassword = userPassword;
            this.countryCode = countryCode;
            this.webapiKey = webapiKey;
            this.localVersion = localVersion;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doLoginResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doLoginResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandlePart;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long userId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public long serverTime;
        
        public doLoginResponse()
        {
        }
        
        public doLoginResponse(string sessionHandlePart, long userId, long serverTime)
        {
            this.sessionHandlePart = sessionHandlePart;
            this.userId = userId;
            this.serverTime = serverTime;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoLoginEncRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doLoginEncRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string userLogin;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public string userHashPassword;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public int countryCode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public string webapiKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public long localVersion;
        
        public doLoginEncRequest()
        {
        }
        
        public doLoginEncRequest(string userLogin, string userHashPassword, int countryCode, string webapiKey, long localVersion)
        {
            this.userLogin = userLogin;
            this.userHashPassword = userHashPassword;
            this.countryCode = countryCode;
            this.webapiKey = webapiKey;
            this.localVersion = localVersion;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doLoginEncResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doLoginEncResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandlePart;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long userId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public long serverTime;
        
        public doLoginEncResponse()
        {
        }
        
        public doLoginEncResponse(string sessionHandlePart, long userId, long serverTime)
        {
            this.sessionHandlePart = sessionHandlePart;
            this.userId = userId;
            this.serverTime = serverTime;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoLoginWithAccessTokenRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doLoginWithAccessTokenRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string accessToken;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public int countryCode;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public string webapiKey;
        
        public doLoginWithAccessTokenRequest()
        {
        }
        
        public doLoginWithAccessTokenRequest(string accessToken, int countryCode, string webapiKey)
        {
            this.accessToken = accessToken;
            this.countryCode = countryCode;
            this.webapiKey = webapiKey;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doLoginWithAccessTokenResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doLoginWithAccessTokenResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandlePart;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long userId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public long serverTime;
        
        public doLoginWithAccessTokenResponse()
        {
        }
        
        public doLoginWithAccessTokenResponse(string sessionHandlePart, long userId, long serverTime)
        {
            this.sessionHandlePart = sessionHandlePart;
            this.userId = userId;
            this.serverTime = serverTime;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoMyAccount2Request", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doMyAccount2Request
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public string accountType;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public int offset;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] itemsArray;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public int limit;
        
        public doMyAccount2Request()
        {
        }
        
        public doMyAccount2Request(string sessionHandle, string accountType, int offset, long[] itemsArray, int limit)
        {
            this.sessionHandle = sessionHandle;
            this.accountType = accountType;
            this.offset = offset;
            this.itemsArray = itemsArray;
            this.limit = limit;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doMyAccount2Response", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doMyAccount2Response
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.MyAccountStruct2[] myaccountList;
        
        public doMyAccount2Response()
        {
        }
        
        public doMyAccount2Response(Allegro.MyAccountStruct2[] myaccountList)
        {
            this.myaccountList = myaccountList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoMyAccountItemsCountRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doMyAccountItemsCountRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public string accountType;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] itemsArray;
        
        public doMyAccountItemsCountRequest()
        {
        }
        
        public doMyAccountItemsCountRequest(string sessionHandle, string accountType, long[] itemsArray)
        {
            this.sessionHandle = sessionHandle;
            this.accountType = accountType;
            this.itemsArray = itemsArray;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doMyAccountItemsCountResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doMyAccountItemsCountResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int myaccountItemsCount;
        
        public doMyAccountItemsCountResponse()
        {
        }
        
        public doMyAccountItemsCountResponse(int myaccountItemsCount)
        {
            this.myaccountItemsCount = myaccountItemsCount;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoMyBillingRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doMyBillingRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        public doMyBillingRequest()
        {
        }
        
        public doMyBillingRequest(string sessionHandle)
        {
            this.sessionHandle = sessionHandle;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doMyBillingResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doMyBillingResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string myBilling;
        
        public doMyBillingResponse()
        {
        }
        
        public doMyBillingResponse(string myBilling)
        {
            this.myBilling = myBilling;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoMyBillingItemRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doMyBillingItemRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long itemId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public string option;
        
        public doMyBillingItemRequest()
        {
        }
        
        public doMyBillingItemRequest(string sessionHandle, long itemId, string option)
        {
            this.sessionHandle = sessionHandle;
            this.itemId = itemId;
            this.option = option;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doMyBillingItemResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doMyBillingItemResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.ItemBilling[] entryFees;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.ItemBilling[] endingFees;
        
        public doMyBillingItemResponse()
        {
        }
        
        public doMyBillingItemResponse(Allegro.ItemBilling[] entryFees, Allegro.ItemBilling[] endingFees)
        {
            this.entryFees = entryFees;
            this.endingFees = endingFees;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoMyContactRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doMyContactRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] auctionIdList;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public int offset;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public int desc;
        
        public doMyContactRequest()
        {
        }
        
        public doMyContactRequest(string sessionHandle, long[] auctionIdList, int offset, int desc)
        {
            this.sessionHandle = sessionHandle;
            this.auctionIdList = auctionIdList;
            this.offset = offset;
            this.desc = desc;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doMyContactResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doMyContactResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.MyContactList[] mycontactList;
        
        public doMyContactResponse()
        {
        }
        
        public doMyContactResponse(Allegro.MyContactList[] mycontactList)
        {
            this.mycontactList = mycontactList;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoNewAuctionExtRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doNewAuctionExtRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.FieldsValue[] fields;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public int itemTemplateId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public int localId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public Allegro.ItemTemplateCreateStruct itemTemplateCreate;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.VariantStruct[] variants;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=6)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.TagNameStruct[] tags;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=7)]
        public Allegro.AfterSalesServiceConditionsStruct afterSalesServiceConditions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=8)]
        public string additionalServicesGroup;
        
        public doNewAuctionExtRequest()
        {
        }
        
        public doNewAuctionExtRequest(string sessionHandle, Allegro.FieldsValue[] fields, int itemTemplateId, int localId, Allegro.ItemTemplateCreateStruct itemTemplateCreate, Allegro.VariantStruct[] variants, Allegro.TagNameStruct[] tags, Allegro.AfterSalesServiceConditionsStruct afterSalesServiceConditions, string additionalServicesGroup)
        {
            this.sessionHandle = sessionHandle;
            this.fields = fields;
            this.itemTemplateId = itemTemplateId;
            this.localId = localId;
            this.itemTemplateCreate = itemTemplateCreate;
            this.variants = variants;
            this.tags = tags;
            this.afterSalesServiceConditions = afterSalesServiceConditions;
            this.additionalServicesGroup = additionalServicesGroup;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doNewAuctionExtResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doNewAuctionExtResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public long itemId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public string itemInfo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public int itemIsAllegroStandard;
        
        public doNewAuctionExtResponse()
        {
        }
        
        public doNewAuctionExtResponse(long itemId, string itemInfo, int itemIsAllegroStandard)
        {
            this.itemId = itemId;
            this.itemInfo = itemInfo;
            this.itemIsAllegroStandard = itemIsAllegroStandard;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoQueryAllSysStatusRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doQueryAllSysStatusRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int countryId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public string webapiKey;
        
        public doQueryAllSysStatusRequest()
        {
        }
        
        public doQueryAllSysStatusRequest(int countryId, string webapiKey)
        {
            this.countryId = countryId;
            this.webapiKey = webapiKey;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doQueryAllSysStatusResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doQueryAllSysStatusResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.SysStatusType[] sysCountryStatus;
        
        public doQueryAllSysStatusResponse()
        {
        }
        
        public doQueryAllSysStatusResponse(Allegro.SysStatusType[] sysCountryStatus)
        {
            this.sysCountryStatus = sysCountryStatus;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoQuerySysStatusRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doQuerySysStatusRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int sysvar;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public int countryId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public string webapiKey;
        
        public doQuerySysStatusRequest()
        {
        }
        
        public doQuerySysStatusRequest(int sysvar, int countryId, string webapiKey)
        {
            this.sysvar = sysvar;
            this.countryId = countryId;
            this.webapiKey = webapiKey;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doQuerySysStatusResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doQuerySysStatusResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string info;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long verKey;
        
        public doQuerySysStatusResponse()
        {
        }
        
        public doQuerySysStatusResponse(string info, long verKey)
        {
            this.info = info;
            this.verKey = verKey;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoRemoveFromBlackListRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doRemoveFromBlackListRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] usersIdArray;
        
        public doRemoveFromBlackListRequest()
        {
        }
        
        public doRemoveFromBlackListRequest(string sessionHandle, long[] usersIdArray)
        {
            this.sessionHandle = sessionHandle;
            this.usersIdArray = usersIdArray;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doRemoveFromBlackListResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doRemoveFromBlackListResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.BlackListResStruct[] blackListResult;
        
        public doRemoveFromBlackListResponse()
        {
        }
        
        public doRemoveFromBlackListResponse(Allegro.BlackListResStruct[] blackListResult)
        {
            this.blackListResult = blackListResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoRequestCancelBidRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doRequestCancelBidRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long requestItemId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public string requestCancelReason;
        
        public doRequestCancelBidRequest()
        {
        }
        
        public doRequestCancelBidRequest(string sessionHandle, long requestItemId, string requestCancelReason)
        {
            this.sessionHandle = sessionHandle;
            this.requestItemId = requestItemId;
            this.requestCancelReason = requestCancelReason;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doRequestCancelBidResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doRequestCancelBidResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int requestValue;
        
        public doRequestCancelBidResponse()
        {
        }
        
        public doRequestCancelBidResponse(int requestValue)
        {
            this.requestValue = requestValue;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoRequestPayoutRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doRequestPayoutRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        public doRequestPayoutRequest()
        {
        }
        
        public doRequestPayoutRequest(string sessionId)
        {
            this.sessionId = sessionId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doRequestPayoutResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doRequestPayoutResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public Allegro.RequestPayoutStruct requestPayout;
        
        public doRequestPayoutResponse()
        {
        }
        
        public doRequestPayoutResponse(Allegro.RequestPayoutStruct requestPayout)
        {
            this.requestPayout = requestPayout;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoRequestSurchargeRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doRequestSurchargeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long transactionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public float surchargeValue;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public string surchargeMessageToBuyer;
        
        public doRequestSurchargeRequest()
        {
        }
        
        public doRequestSurchargeRequest(string sessionHandle, long transactionId, float surchargeValue, string surchargeMessageToBuyer)
        {
            this.sessionHandle = sessionHandle;
            this.transactionId = transactionId;
            this.surchargeValue = surchargeValue;
            this.surchargeMessageToBuyer = surchargeMessageToBuyer;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doRequestSurchargeResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doRequestSurchargeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int surchargeResult;
        
        public doRequestSurchargeResponse()
        {
        }
        
        public doRequestSurchargeResponse(int surchargeResult)
        {
            this.surchargeResult = surchargeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoSellSomeAgainRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doSellSomeAgainRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] sellItemsArray;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public long sellStartingTime;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public int sellAuctionDuration;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public int sellOptions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public int[] localIds;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=6)]
        public int sellProlongOptions;
        
        public doSellSomeAgainRequest()
        {
        }
        
        public doSellSomeAgainRequest(string sessionHandle, long[] sellItemsArray, long sellStartingTime, int sellAuctionDuration, int sellOptions, int[] localIds, int sellProlongOptions)
        {
            this.sessionHandle = sessionHandle;
            this.sellItemsArray = sellItemsArray;
            this.sellStartingTime = sellStartingTime;
            this.sellAuctionDuration = sellAuctionDuration;
            this.sellOptions = sellOptions;
            this.localIds = localIds;
            this.sellProlongOptions = sellProlongOptions;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doSellSomeAgainResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doSellSomeAgainResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.StructSellAgain[] itemsSellAgain;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.StructSellFailed[] itemsSellFailed;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] itemsSellNotFound;
        
        public doSellSomeAgainResponse()
        {
        }
        
        public doSellSomeAgainResponse(Allegro.StructSellAgain[] itemsSellAgain, Allegro.StructSellFailed[] itemsSellFailed, long[] itemsSellNotFound)
        {
            this.itemsSellAgain = itemsSellAgain;
            this.itemsSellFailed = itemsSellFailed;
            this.itemsSellNotFound = itemsSellNotFound;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoSellSomeAgainInShopRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doSellSomeAgainInShopRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] sellItemsArray;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public long sellStartingTime;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public int sellShopDuration;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public int sellShopOptions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=5)]
        public int sellProlongOptions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=6)]
        public long sellShopCategory;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=7)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public int[] localIds;
        
        public doSellSomeAgainInShopRequest()
        {
        }
        
        public doSellSomeAgainInShopRequest(string sessionHandle, long[] sellItemsArray, long sellStartingTime, int sellShopDuration, int sellShopOptions, int sellProlongOptions, long sellShopCategory, int[] localIds)
        {
            this.sessionHandle = sessionHandle;
            this.sellItemsArray = sellItemsArray;
            this.sellStartingTime = sellStartingTime;
            this.sellShopDuration = sellShopDuration;
            this.sellShopOptions = sellShopOptions;
            this.sellProlongOptions = sellProlongOptions;
            this.sellShopCategory = sellShopCategory;
            this.localIds = localIds;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doSellSomeAgainInShopResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doSellSomeAgainInShopResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.StructSellAgain[] itemsSellAgain;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.StructSellFailed[] itemsSellFailed;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public long[] itemsSellNotFound;
        
        public doSellSomeAgainInShopResponse()
        {
        }
        
        public doSellSomeAgainInShopResponse(Allegro.StructSellAgain[] itemsSellAgain, Allegro.StructSellFailed[] itemsSellFailed, long[] itemsSellNotFound)
        {
            this.itemsSellAgain = itemsSellAgain;
            this.itemsSellFailed = itemsSellFailed;
            this.itemsSellNotFound = itemsSellNotFound;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoSendEmailToUserRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doSendEmailToUserRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long mailToUserItemId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public long mailToUserReceiverId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public int mailToUserSubjectId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public int mailToUserOption;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=5)]
        public string mailToUserMessage;
        
        public doSendEmailToUserRequest()
        {
        }
        
        public doSendEmailToUserRequest(string sessionHandle, long mailToUserItemId, long mailToUserReceiverId, int mailToUserSubjectId, int mailToUserOption, string mailToUserMessage)
        {
            this.sessionHandle = sessionHandle;
            this.mailToUserItemId = mailToUserItemId;
            this.mailToUserReceiverId = mailToUserReceiverId;
            this.mailToUserSubjectId = mailToUserSubjectId;
            this.mailToUserOption = mailToUserOption;
            this.mailToUserMessage = mailToUserMessage;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doSendEmailToUserResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doSendEmailToUserResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public long mailToUserReceiverId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public string mailToUserResult;
        
        public doSendEmailToUserResponse()
        {
        }
        
        public doSendEmailToUserResponse(long mailToUserReceiverId, string mailToUserResult)
        {
            this.mailToUserReceiverId = mailToUserReceiverId;
            this.mailToUserResult = mailToUserResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoSendPostBuyFormRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doSendPostBuyFormRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.NewPostBuyFormSellerStruct[] newPostBuyFormSeller;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public Allegro.NewPostBuyFormCommonStruct newPostBuyFormCommon;
        
        public doSendPostBuyFormRequest()
        {
        }
        
        public doSendPostBuyFormRequest(string sessionId, Allegro.NewPostBuyFormSellerStruct[] newPostBuyFormSeller, Allegro.NewPostBuyFormCommonStruct newPostBuyFormCommon)
        {
            this.sessionId = sessionId;
            this.newPostBuyFormSeller = newPostBuyFormSeller;
            this.newPostBuyFormCommon = newPostBuyFormCommon;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doSendPostBuyFormResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doSendPostBuyFormResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public Allegro.PostBuyFormStruct postBuyForm;
        
        public doSendPostBuyFormResponse()
        {
        }
        
        public doSendPostBuyFormResponse(Allegro.PostBuyFormStruct postBuyForm)
        {
            this.postBuyForm = postBuyForm;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoSendRefundFormRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doSendRefundFormRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public int dealId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public int reasonId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public int refundQuantity;
        
        public doSendRefundFormRequest()
        {
        }
        
        public doSendRefundFormRequest(string sessionId, int dealId, int reasonId, int refundQuantity)
        {
            this.sessionId = sessionId;
            this.dealId = dealId;
            this.reasonId = reasonId;
            this.refundQuantity = refundQuantity;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doSendRefundFormResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doSendRefundFormResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int refundId;
        
        public doSendRefundFormResponse()
        {
        }
        
        public doSendRefundFormResponse(int refundId)
        {
            this.refundId = refundId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoSetFreeDeliveryAmountRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doSetFreeDeliveryAmountRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public int activeFlag;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public float freeDeliveryAmount;
        
        public doSetFreeDeliveryAmountRequest()
        {
        }
        
        public doSetFreeDeliveryAmountRequest(string sessionId, int activeFlag, float freeDeliveryAmount)
        {
            this.sessionId = sessionId;
            this.activeFlag = activeFlag;
            this.freeDeliveryAmount = freeDeliveryAmount;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doSetFreeDeliveryAmountResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doSetFreeDeliveryAmountResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public bool responseStatus;
        
        public doSetFreeDeliveryAmountResponse()
        {
        }
        
        public doSetFreeDeliveryAmountResponse(bool responseStatus)
        {
            this.responseStatus = responseStatus;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoSetShipmentPriceTypeRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doSetShipmentPriceTypeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public int shipmentPriceTypeId;
        
        public doSetShipmentPriceTypeRequest()
        {
        }
        
        public doSetShipmentPriceTypeRequest(string sessionId, int shipmentPriceTypeId)
        {
            this.sessionId = sessionId;
            this.shipmentPriceTypeId = shipmentPriceTypeId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doSetShipmentPriceTypeResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doSetShipmentPriceTypeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public int operationResult;
        
        public doSetShipmentPriceTypeResponse()
        {
        }
        
        public doSetShipmentPriceTypeResponse(int operationResult)
        {
            this.operationResult = operationResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoShowItemInfoExtRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doShowItemInfoExtRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public long itemId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public int getDesc;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public int getImageUrl;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public int getAttribs;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=5)]
        public int getPostageOptions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=6)]
        public int getCompanyInfo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=7)]
        public int getProductInfo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=8)]
        public int getAfterSalesServiceConditions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=9)]
        public int getEan;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=10)]
        public int getAdditionalServicesGroup;
        
        public doShowItemInfoExtRequest()
        {
        }
        
        public doShowItemInfoExtRequest(string sessionHandle, long itemId, int getDesc, int getImageUrl, int getAttribs, int getPostageOptions, int getCompanyInfo, int getProductInfo, int getAfterSalesServiceConditions, int getEan, int getAdditionalServicesGroup)
        {
            this.sessionHandle = sessionHandle;
            this.itemId = itemId;
            this.getDesc = getDesc;
            this.getImageUrl = getImageUrl;
            this.getAttribs = getAttribs;
            this.getPostageOptions = getPostageOptions;
            this.getCompanyInfo = getCompanyInfo;
            this.getProductInfo = getProductInfo;
            this.getAfterSalesServiceConditions = getAfterSalesServiceConditions;
            this.getEan = getEan;
            this.getAdditionalServicesGroup = getAdditionalServicesGroup;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doShowItemInfoExtResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doShowItemInfoExtResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public Allegro.ItemInfoExt itemListInfoExt;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.ItemCatList[] itemCatPath;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.ItemImageList[] itemImgList;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.AttribStruct[] itemAttribList;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.PostageStruct[] itemPostageOptions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=5)]
        public Allegro.ItemPaymentOptions itemPaymentOptions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=6)]
        public Allegro.CompanyInfoStruct itemCompanyInfo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=7)]
        public Allegro.ProductStruct itemProductInfo;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=8)]
        public string itemVariants;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=9)]
        public Allegro.AfterSalesServiceConditionsStruct itemAfterSalesServiceConditions;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=10)]
        public string itemAdditionalServicesGroup;
        
        public doShowItemInfoExtResponse()
        {
        }
        
        public doShowItemInfoExtResponse(Allegro.ItemInfoExt itemListInfoExt, Allegro.ItemCatList[] itemCatPath, Allegro.ItemImageList[] itemImgList, Allegro.AttribStruct[] itemAttribList, Allegro.PostageStruct[] itemPostageOptions, Allegro.ItemPaymentOptions itemPaymentOptions, Allegro.CompanyInfoStruct itemCompanyInfo, Allegro.ProductStruct itemProductInfo, string itemVariants, Allegro.AfterSalesServiceConditionsStruct itemAfterSalesServiceConditions, string itemAdditionalServicesGroup)
        {
            this.itemListInfoExt = itemListInfoExt;
            this.itemCatPath = itemCatPath;
            this.itemImgList = itemImgList;
            this.itemAttribList = itemAttribList;
            this.itemPostageOptions = itemPostageOptions;
            this.itemPaymentOptions = itemPaymentOptions;
            this.itemCompanyInfo = itemCompanyInfo;
            this.itemProductInfo = itemProductInfo;
            this.itemVariants = itemVariants;
            this.itemAfterSalesServiceConditions = itemAfterSalesServiceConditions;
            this.itemAdditionalServicesGroup = itemAdditionalServicesGroup;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoShowUserRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doShowUserRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string webapiKey;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public int countryId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public long userId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public string userLogin;
        
        public doShowUserRequest()
        {
        }
        
        public doShowUserRequest(string webapiKey, int countryId, long userId, string userLogin)
        {
            this.webapiKey = webapiKey;
            this.countryId = countryId;
            this.userId = userId;
            this.userLogin = userLogin;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doShowUserResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doShowUserResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public long userId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public string userLogin;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public int userCountry;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=3)]
        public long userCreateDate;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=4)]
        public long userLoginDate;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=5)]
        public int userRating;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=6)]
        public int userIsNewUser;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=7)]
        public int userNotActivated;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=8)]
        public int userClosed;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=9)]
        public int userBlocked;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=10)]
        public int userTerminated;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=11)]
        public int userHasPage;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=12)]
        public int userIsSseller;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=13)]
        public int userIsEco;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=14)]
        public Allegro.ShowUserFeedbacks userPositiveFeedback;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=15)]
        public Allegro.ShowUserFeedbacks userNegativeFeedback;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=16)]
        public Allegro.ShowUserFeedbacks userNeutralFeedback;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=17)]
        public int userJuniorStatus;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=18)]
        public int userHasShop;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=19)]
        public int userCompanyIcon;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=20)]
        public int userSellRatingCount;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=21)]
        [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable=false)]
        public Allegro.SellRatingAverageStruct[] userSellRatingAverage;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=22)]
        public int userIsAllegroStandard;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=23)]
        public int userIsB2cSeller;
        
        public doShowUserResponse()
        {
        }
        
        public doShowUserResponse(
                    long userId, 
                    string userLogin, 
                    int userCountry, 
                    long userCreateDate, 
                    long userLoginDate, 
                    int userRating, 
                    int userIsNewUser, 
                    int userNotActivated, 
                    int userClosed, 
                    int userBlocked, 
                    int userTerminated, 
                    int userHasPage, 
                    int userIsSseller, 
                    int userIsEco, 
                    Allegro.ShowUserFeedbacks userPositiveFeedback, 
                    Allegro.ShowUserFeedbacks userNegativeFeedback, 
                    Allegro.ShowUserFeedbacks userNeutralFeedback, 
                    int userJuniorStatus, 
                    int userHasShop, 
                    int userCompanyIcon, 
                    int userSellRatingCount, 
                    Allegro.SellRatingAverageStruct[] userSellRatingAverage, 
                    int userIsAllegroStandard, 
                    int userIsB2cSeller)
        {
            this.userId = userId;
            this.userLogin = userLogin;
            this.userCountry = userCountry;
            this.userCreateDate = userCreateDate;
            this.userLoginDate = userLoginDate;
            this.userRating = userRating;
            this.userIsNewUser = userIsNewUser;
            this.userNotActivated = userNotActivated;
            this.userClosed = userClosed;
            this.userBlocked = userBlocked;
            this.userTerminated = userTerminated;
            this.userHasPage = userHasPage;
            this.userIsSseller = userIsSseller;
            this.userIsEco = userIsEco;
            this.userPositiveFeedback = userPositiveFeedback;
            this.userNegativeFeedback = userNegativeFeedback;
            this.userNeutralFeedback = userNeutralFeedback;
            this.userJuniorStatus = userJuniorStatus;
            this.userHasShop = userHasShop;
            this.userCompanyIcon = userCompanyIcon;
            this.userSellRatingCount = userSellRatingCount;
            this.userSellRatingAverage = userSellRatingAverage;
            this.userIsAllegroStandard = userIsAllegroStandard;
            this.userIsB2cSeller = userIsB2cSeller;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DoVerifyItemRequest", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doVerifyItemRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public string sessionHandle;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public int localId;
        
        public doVerifyItemRequest()
        {
        }
        
        public doVerifyItemRequest(string sessionHandle, int localId)
        {
            this.sessionHandle = sessionHandle;
            this.localId = localId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="doVerifyItemResponse", WrapperNamespace="https://webapi.allegro.pl/service.php", IsWrapped=true)]
    public partial class doVerifyItemResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=0)]
        public long itemId;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=1)]
        public int itemListed;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="https://webapi.allegro.pl/service.php", Order=2)]
        public long itemStartingTime;
        
        public doVerifyItemResponse()
        {
        }
        
        public doVerifyItemResponse(long itemId, int itemListed, long itemStartingTime)
        {
            this.itemId = itemId;
            this.itemListed = itemListed;
            this.itemStartingTime = itemStartingTime;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface servicePortChannel : Allegro.servicePort, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class servicePortClient : System.ServiceModel.ClientBase<Allegro.servicePort>, Allegro.servicePort
    {
        
    /// <summary>
    /// Wdróż tę metodę częściową, aby skonfigurować punkt końcowy usługi.
    /// </summary>
    /// <param name="serviceEndpoint">Punkt końcowy do skonfigurowania</param>
    /// <param name="clientCredentials">Poświadczenia klienta</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public servicePortClient() : 
                base(servicePortClient.GetDefaultBinding(), servicePortClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.servicePort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public servicePortClient(EndpointConfiguration endpointConfiguration) : 
                base(servicePortClient.GetBindingForEndpoint(endpointConfiguration), servicePortClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public servicePortClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(servicePortClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public servicePortClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(servicePortClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public servicePortClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doAddPackageInfoToPostBuyFormResponse> Allegro.servicePort.doAddPackageInfoToPostBuyFormAsync(Allegro.doAddPackageInfoToPostBuyFormRequest request)
        {
            return base.Channel.doAddPackageInfoToPostBuyFormAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doAddPackageInfoToPostBuyFormResponse> doAddPackageInfoToPostBuyFormAsync(string sessionId, long transactionId, Allegro.PackageInfoStruct[] packageInfo)
        {
            Allegro.doAddPackageInfoToPostBuyFormRequest inValue = new Allegro.doAddPackageInfoToPostBuyFormRequest();
            inValue.sessionId = sessionId;
            inValue.transactionId = transactionId;
            inValue.packageInfo = packageInfo;
            return ((Allegro.servicePort)(this)).doAddPackageInfoToPostBuyFormAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doAddToBlackListResponse> Allegro.servicePort.doAddToBlackListAsync(Allegro.doAddToBlackListRequest request)
        {
            return base.Channel.doAddToBlackListAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doAddToBlackListResponse> doAddToBlackListAsync(string sessionHandle, Allegro.UserBlackListStruct[] usersBlackListArray)
        {
            Allegro.doAddToBlackListRequest inValue = new Allegro.doAddToBlackListRequest();
            inValue.sessionHandle = sessionHandle;
            inValue.usersBlackListArray = usersBlackListArray;
            return ((Allegro.servicePort)(this)).doAddToBlackListAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doBidItemResponse> Allegro.servicePort.doBidItemAsync(Allegro.doBidItemRequest request)
        {
            return base.Channel.doBidItemAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doBidItemResponse> doBidItemAsync(string sessionHandle, long bidItId, float bidUserPrice, long bidQuantity, long bidBuyNow, Allegro.PharmacyRecipientDataStruct pharmacyRecipientData, string variantId)
        {
            Allegro.doBidItemRequest inValue = new Allegro.doBidItemRequest();
            inValue.sessionHandle = sessionHandle;
            inValue.bidItId = bidItId;
            inValue.bidUserPrice = bidUserPrice;
            inValue.bidQuantity = bidQuantity;
            inValue.bidBuyNow = bidBuyNow;
            inValue.pharmacyRecipientData = pharmacyRecipientData;
            inValue.variantId = variantId;
            return ((Allegro.servicePort)(this)).doBidItemAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Allegro.doCancelBidItemResponse> doCancelBidItemAsync(Allegro.doCancelBidItemRequest request)
        {
            return base.Channel.doCancelBidItemAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doCancelRefundFormResponse> Allegro.servicePort.doCancelRefundFormAsync(Allegro.doCancelRefundFormRequest request)
        {
            return base.Channel.doCancelRefundFormAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doCancelRefundFormResponse> doCancelRefundFormAsync(string sessionId, int refundId)
        {
            Allegro.doCancelRefundFormRequest inValue = new Allegro.doCancelRefundFormRequest();
            inValue.sessionId = sessionId;
            inValue.refundId = refundId;
            return ((Allegro.servicePort)(this)).doCancelRefundFormAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doCancelRefundWarningResponse> Allegro.servicePort.doCancelRefundWarningAsync(Allegro.doCancelRefundWarningRequest request)
        {
            return base.Channel.doCancelRefundWarningAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doCancelRefundWarningResponse> doCancelRefundWarningAsync(string sessionId, int refundId)
        {
            Allegro.doCancelRefundWarningRequest inValue = new Allegro.doCancelRefundWarningRequest();
            inValue.sessionId = sessionId;
            inValue.refundId = refundId;
            return ((Allegro.servicePort)(this)).doCancelRefundWarningAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doCancelTransactionResponse> Allegro.servicePort.doCancelTransactionAsync(Allegro.doCancelTransactionRequest request)
        {
            return base.Channel.doCancelTransactionAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doCancelTransactionResponse> doCancelTransactionAsync(string sessionId, long transactionId)
        {
            Allegro.doCancelTransactionRequest inValue = new Allegro.doCancelTransactionRequest();
            inValue.sessionId = sessionId;
            inValue.transactionId = transactionId;
            return ((Allegro.servicePort)(this)).doCancelTransactionAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doChangeItemFieldsResponse> Allegro.servicePort.doChangeItemFieldsAsync(Allegro.doChangeItemFieldsRequest request)
        {
            return base.Channel.doChangeItemFieldsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doChangeItemFieldsResponse> doChangeItemFieldsAsync(string sessionId, long itemId, Allegro.FieldsValue[] fieldsToModify, int[] fieldsToRemove, int previewOnly, Allegro.VariantStruct[] variants, Allegro.TagNameStruct[] tags, Allegro.AfterSalesServiceConditionsStruct afterSalesServiceConditions, string additionalServicesGroup)
        {
            Allegro.doChangeItemFieldsRequest inValue = new Allegro.doChangeItemFieldsRequest();
            inValue.sessionId = sessionId;
            inValue.itemId = itemId;
            inValue.fieldsToModify = fieldsToModify;
            inValue.fieldsToRemove = fieldsToRemove;
            inValue.previewOnly = previewOnly;
            inValue.variants = variants;
            inValue.tags = tags;
            inValue.afterSalesServiceConditions = afterSalesServiceConditions;
            inValue.additionalServicesGroup = additionalServicesGroup;
            return ((Allegro.servicePort)(this)).doChangeItemFieldsAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Allegro.doChangePriceItemResponse> doChangePriceItemAsync(Allegro.doChangePriceItemRequest request)
        {
            return base.Channel.doChangePriceItemAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doChangeQuantityItemResponse> doChangeQuantityItemAsync(Allegro.doChangeQuantityItemRequest request)
        {
            return base.Channel.doChangeQuantityItemAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doCheckItemDescriptionResponse> Allegro.servicePort.doCheckItemDescriptionAsync(Allegro.doCheckItemDescriptionRequest request)
        {
            return base.Channel.doCheckItemDescriptionAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doCheckItemDescriptionResponse> doCheckItemDescriptionAsync(string sessionId, string descriptionContent)
        {
            Allegro.doCheckItemDescriptionRequest inValue = new Allegro.doCheckItemDescriptionRequest();
            inValue.sessionId = sessionId;
            inValue.descriptionContent = descriptionContent;
            return ((Allegro.servicePort)(this)).doCheckItemDescriptionAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Allegro.doCheckNewAuctionExtResponse> doCheckNewAuctionExtAsync(Allegro.doCheckNewAuctionExtRequest request)
        {
            return base.Channel.doCheckNewAuctionExtAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doFinishItemResponse> Allegro.servicePort.doFinishItemAsync(Allegro.doFinishItemRequest request)
        {
            return base.Channel.doFinishItemAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doFinishItemResponse> doFinishItemAsync(string sessionHandle, long finishItemId, int finishCancelAllBids, string finishCancelReason)
        {
            Allegro.doFinishItemRequest inValue = new Allegro.doFinishItemRequest();
            inValue.sessionHandle = sessionHandle;
            inValue.finishItemId = finishItemId;
            inValue.finishCancelAllBids = finishCancelAllBids;
            inValue.finishCancelReason = finishCancelReason;
            return ((Allegro.servicePort)(this)).doFinishItemAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Allegro.doFinishItemsResponse> doFinishItemsAsync(Allegro.doFinishItemsRequest request)
        {
            return base.Channel.doFinishItemsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetArchiveRefundsListResponse> doGetArchiveRefundsListAsync(Allegro.doGetArchiveRefundsListRequest request)
        {
            return base.Channel.doGetArchiveRefundsListAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetBidItem2Response> Allegro.servicePort.doGetBidItem2Async(Allegro.doGetBidItem2Request request)
        {
            return base.Channel.doGetBidItem2Async(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetBidItem2Response> doGetBidItem2Async(string sessionHandle, long itemId)
        {
            Allegro.doGetBidItem2Request inValue = new Allegro.doGetBidItem2Request();
            inValue.sessionHandle = sessionHandle;
            inValue.itemId = itemId;
            return ((Allegro.servicePort)(this)).doGetBidItem2Async(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetBlackListUsersResponse> Allegro.servicePort.doGetBlackListUsersAsync(Allegro.doGetBlackListUsersRequest request)
        {
            return base.Channel.doGetBlackListUsersAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetBlackListUsersResponse> doGetBlackListUsersAsync(string sessionHandle)
        {
            Allegro.doGetBlackListUsersRequest inValue = new Allegro.doGetBlackListUsersRequest();
            inValue.sessionHandle = sessionHandle;
            return ((Allegro.servicePort)(this)).doGetBlackListUsersAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetCategoryPathResponse> Allegro.servicePort.doGetCategoryPathAsync(Allegro.doGetCategoryPathRequest request)
        {
            return base.Channel.doGetCategoryPathAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetCategoryPathResponse> doGetCategoryPathAsync(string sessionId, int categoryId)
        {
            Allegro.doGetCategoryPathRequest inValue = new Allegro.doGetCategoryPathRequest();
            inValue.sessionId = sessionId;
            inValue.categoryId = categoryId;
            return ((Allegro.servicePort)(this)).doGetCategoryPathAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetCatsDataResponse> doGetCatsDataAsync(Allegro.doGetCatsDataRequest request)
        {
            return base.Channel.doGetCatsDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetCatsDataCountResponse> doGetCatsDataCountAsync(Allegro.doGetCatsDataCountRequest request)
        {
            return base.Channel.doGetCatsDataCountAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetCatsDataLimitResponse> doGetCatsDataLimitAsync(Allegro.doGetCatsDataLimitRequest request)
        {
            return base.Channel.doGetCatsDataLimitAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetCountriesResponse> Allegro.servicePort.doGetCountriesAsync(Allegro.doGetCountriesRequest request)
        {
            return base.Channel.doGetCountriesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetCountriesResponse> doGetCountriesAsync(int countryCode, string webapiKey)
        {
            Allegro.doGetCountriesRequest inValue = new Allegro.doGetCountriesRequest();
            inValue.countryCode = countryCode;
            inValue.webapiKey = webapiKey;
            return ((Allegro.servicePort)(this)).doGetCountriesAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetDealsResponse> Allegro.servicePort.doGetDealsAsync(Allegro.doGetDealsRequest request)
        {
            return base.Channel.doGetDealsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetDealsResponse> doGetDealsAsync(string sessionHandle, long itemId, int buyerId)
        {
            Allegro.doGetDealsRequest inValue = new Allegro.doGetDealsRequest();
            inValue.sessionHandle = sessionHandle;
            inValue.itemId = itemId;
            inValue.buyerId = buyerId;
            return ((Allegro.servicePort)(this)).doGetDealsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetFilledPostBuyFormsResponse> Allegro.servicePort.doGetFilledPostBuyFormsAsync(Allegro.doGetFilledPostBuyFormsRequest request)
        {
            return base.Channel.doGetFilledPostBuyFormsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetFilledPostBuyFormsResponse> doGetFilledPostBuyFormsAsync(string sessionId, int paymentType, int userRole, long fillingTimeFrom, long fillingTimeTo)
        {
            Allegro.doGetFilledPostBuyFormsRequest inValue = new Allegro.doGetFilledPostBuyFormsRequest();
            inValue.sessionId = sessionId;
            inValue.paymentType = paymentType;
            inValue.userRole = userRole;
            inValue.fillingTimeFrom = fillingTimeFrom;
            inValue.fillingTimeTo = fillingTimeTo;
            return ((Allegro.servicePort)(this)).doGetFilledPostBuyFormsAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetFreeDeliveryAmountResponse> doGetFreeDeliveryAmountAsync(Allegro.doGetFreeDeliveryAmountRequest request)
        {
            return base.Channel.doGetFreeDeliveryAmountAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetItemFieldsResponse> doGetItemFieldsAsync(Allegro.doGetItemFieldsRequest request)
        {
            return base.Channel.doGetItemFieldsAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetItemsImagesResponse> Allegro.servicePort.doGetItemsImagesAsync(Allegro.doGetItemsImagesRequest request)
        {
            return base.Channel.doGetItemsImagesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetItemsImagesResponse> doGetItemsImagesAsync(string sessionHandle, Allegro.ItemGetImage[] itemsArray, int imageType)
        {
            Allegro.doGetItemsImagesRequest inValue = new Allegro.doGetItemsImagesRequest();
            inValue.sessionHandle = sessionHandle;
            inValue.itemsArray = itemsArray;
            inValue.imageType = imageType;
            return ((Allegro.servicePort)(this)).doGetItemsImagesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetItemsInfoResponse> doGetItemsInfoAsync(Allegro.doGetItemsInfoRequest request)
        {
            return base.Channel.doGetItemsInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetItemsListResponse> doGetItemsListAsync(Allegro.doGetItemsListRequest request)
        {
            return base.Channel.doGetItemsListAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetMessageToBuyerResponse> Allegro.servicePort.doGetMessageToBuyerAsync(Allegro.doGetMessageToBuyerRequest request)
        {
            return base.Channel.doGetMessageToBuyerAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetMessageToBuyerResponse> doGetMessageToBuyerAsync(string sessionId, long itemId)
        {
            Allegro.doGetMessageToBuyerRequest inValue = new Allegro.doGetMessageToBuyerRequest();
            inValue.sessionId = sessionId;
            inValue.itemId = itemId;
            return ((Allegro.servicePort)(this)).doGetMessageToBuyerAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetMyAddressesResponse> Allegro.servicePort.doGetMyAddressesAsync(Allegro.doGetMyAddressesRequest request)
        {
            return base.Channel.doGetMyAddressesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetMyAddressesResponse> doGetMyAddressesAsync(string sessionId)
        {
            Allegro.doGetMyAddressesRequest inValue = new Allegro.doGetMyAddressesRequest();
            inValue.sessionId = sessionId;
            return ((Allegro.servicePort)(this)).doGetMyAddressesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetMyBidItemsResponse> doGetMyBidItemsAsync(Allegro.doGetMyBidItemsRequest request)
        {
            return base.Channel.doGetMyBidItemsAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetMyCurrentShipmentPriceTypeResponse> Allegro.servicePort.doGetMyCurrentShipmentPriceTypeAsync(Allegro.doGetMyCurrentShipmentPriceTypeRequest request)
        {
            return base.Channel.doGetMyCurrentShipmentPriceTypeAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetMyCurrentShipmentPriceTypeResponse> doGetMyCurrentShipmentPriceTypeAsync(string sessionId)
        {
            Allegro.doGetMyCurrentShipmentPriceTypeRequest inValue = new Allegro.doGetMyCurrentShipmentPriceTypeRequest();
            inValue.sessionId = sessionId;
            return ((Allegro.servicePort)(this)).doGetMyCurrentShipmentPriceTypeAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetMyDataResponse> doGetMyDataAsync(Allegro.doGetMyDataRequest request)
        {
            return base.Channel.doGetMyDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetMyFutureItemsResponse> doGetMyFutureItemsAsync(Allegro.doGetMyFutureItemsRequest request)
        {
            return base.Channel.doGetMyFutureItemsAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetMyIncomingPaymentsResponse> Allegro.servicePort.doGetMyIncomingPaymentsAsync(Allegro.doGetMyIncomingPaymentsRequest request)
        {
            return base.Channel.doGetMyIncomingPaymentsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetMyIncomingPaymentsResponse> doGetMyIncomingPaymentsAsync(string sessionHandle, int buyerId, long itemId, long transRecvDateFrom, long transRecvDateTo, int transPageLimit, int transOffset, int strictedSearch)
        {
            Allegro.doGetMyIncomingPaymentsRequest inValue = new Allegro.doGetMyIncomingPaymentsRequest();
            inValue.sessionHandle = sessionHandle;
            inValue.buyerId = buyerId;
            inValue.itemId = itemId;
            inValue.transRecvDateFrom = transRecvDateFrom;
            inValue.transRecvDateTo = transRecvDateTo;
            inValue.transPageLimit = transPageLimit;
            inValue.transOffset = transOffset;
            inValue.strictedSearch = strictedSearch;
            return ((Allegro.servicePort)(this)).doGetMyIncomingPaymentsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetMyIncomingPaymentsRefundsResponse> Allegro.servicePort.doGetMyIncomingPaymentsRefundsAsync(Allegro.doGetMyIncomingPaymentsRefundsRequest request)
        {
            return base.Channel.doGetMyIncomingPaymentsRefundsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetMyIncomingPaymentsRefundsResponse> doGetMyIncomingPaymentsRefundsAsync(string sessionHandle, int buyerId, long itemId, int limit, int offset)
        {
            Allegro.doGetMyIncomingPaymentsRefundsRequest inValue = new Allegro.doGetMyIncomingPaymentsRefundsRequest();
            inValue.sessionHandle = sessionHandle;
            inValue.buyerId = buyerId;
            inValue.itemId = itemId;
            inValue.limit = limit;
            inValue.offset = offset;
            return ((Allegro.servicePort)(this)).doGetMyIncomingPaymentsRefundsAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetMyNotSoldItemsResponse> doGetMyNotSoldItemsAsync(Allegro.doGetMyNotSoldItemsRequest request)
        {
            return base.Channel.doGetMyNotSoldItemsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetMyNotWonItemsResponse> doGetMyNotWonItemsAsync(Allegro.doGetMyNotWonItemsRequest request)
        {
            return base.Channel.doGetMyNotWonItemsAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetMyPaymentsResponse> Allegro.servicePort.doGetMyPaymentsAsync(Allegro.doGetMyPaymentsRequest request)
        {
            return base.Channel.doGetMyPaymentsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetMyPaymentsResponse> doGetMyPaymentsAsync(string sessionId, int sellerId, long itemId, long paymentTimeFrom, long paymentTimeTo, int pageSize, int pageNumber, int strictedSearch)
        {
            Allegro.doGetMyPaymentsRequest inValue = new Allegro.doGetMyPaymentsRequest();
            inValue.sessionId = sessionId;
            inValue.sellerId = sellerId;
            inValue.itemId = itemId;
            inValue.paymentTimeFrom = paymentTimeFrom;
            inValue.paymentTimeTo = paymentTimeTo;
            inValue.pageSize = pageSize;
            inValue.pageNumber = pageNumber;
            inValue.strictedSearch = strictedSearch;
            return ((Allegro.servicePort)(this)).doGetMyPaymentsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetMyPaymentsInfoResponse> Allegro.servicePort.doGetMyPaymentsInfoAsync(Allegro.doGetMyPaymentsInfoRequest request)
        {
            return base.Channel.doGetMyPaymentsInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetMyPaymentsInfoResponse> doGetMyPaymentsInfoAsync(string sessionId)
        {
            Allegro.doGetMyPaymentsInfoRequest inValue = new Allegro.doGetMyPaymentsInfoRequest();
            inValue.sessionId = sessionId;
            return ((Allegro.servicePort)(this)).doGetMyPaymentsInfoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetMyPaymentsRefundsResponse> Allegro.servicePort.doGetMyPaymentsRefundsAsync(Allegro.doGetMyPaymentsRefundsRequest request)
        {
            return base.Channel.doGetMyPaymentsRefundsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetMyPaymentsRefundsResponse> doGetMyPaymentsRefundsAsync(string sessionHandle, int sellerId, long itemId, int limit, int offset)
        {
            Allegro.doGetMyPaymentsRefundsRequest inValue = new Allegro.doGetMyPaymentsRefundsRequest();
            inValue.sessionHandle = sessionHandle;
            inValue.sellerId = sellerId;
            inValue.itemId = itemId;
            inValue.limit = limit;
            inValue.offset = offset;
            return ((Allegro.servicePort)(this)).doGetMyPaymentsRefundsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetMyPayoutsResponse> Allegro.servicePort.doGetMyPayoutsAsync(Allegro.doGetMyPayoutsRequest request)
        {
            return base.Channel.doGetMyPayoutsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetMyPayoutsResponse> doGetMyPayoutsAsync(string sessionHandle, long transCreateDateFrom, long transCreateDateTo, int transPageLimit, int transOffset)
        {
            Allegro.doGetMyPayoutsRequest inValue = new Allegro.doGetMyPayoutsRequest();
            inValue.sessionHandle = sessionHandle;
            inValue.transCreateDateFrom = transCreateDateFrom;
            inValue.transCreateDateTo = transCreateDateTo;
            inValue.transPageLimit = transPageLimit;
            inValue.transOffset = transOffset;
            return ((Allegro.servicePort)(this)).doGetMyPayoutsAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetMyPayoutsDetailsResponse> doGetMyPayoutsDetailsAsync(Allegro.doGetMyPayoutsDetailsRequest request)
        {
            return base.Channel.doGetMyPayoutsDetailsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetMySellItemsResponse> doGetMySellItemsAsync(Allegro.doGetMySellItemsRequest request)
        {
            return base.Channel.doGetMySellItemsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetMySoldItemsResponse> doGetMySoldItemsAsync(Allegro.doGetMySoldItemsRequest request)
        {
            return base.Channel.doGetMySoldItemsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetMyWonItemsResponse> doGetMyWonItemsAsync(Allegro.doGetMyWonItemsRequest request)
        {
            return base.Channel.doGetMyWonItemsAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetPaymentMethodsResponse> Allegro.servicePort.doGetPaymentMethodsAsync(Allegro.doGetPaymentMethodsRequest request)
        {
            return base.Channel.doGetPaymentMethodsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetPaymentMethodsResponse> doGetPaymentMethodsAsync(string sessionId, long[] itemIds)
        {
            Allegro.doGetPaymentMethodsRequest inValue = new Allegro.doGetPaymentMethodsRequest();
            inValue.sessionId = sessionId;
            inValue.itemIds = itemIds;
            return ((Allegro.servicePort)(this)).doGetPaymentMethodsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetPostBuyDataResponse> Allegro.servicePort.doGetPostBuyDataAsync(Allegro.doGetPostBuyDataRequest request)
        {
            return base.Channel.doGetPostBuyDataAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetPostBuyDataResponse> doGetPostBuyDataAsync(string sessionHandle, long[] itemsArray, long[] buyerFilterArray)
        {
            Allegro.doGetPostBuyDataRequest inValue = new Allegro.doGetPostBuyDataRequest();
            inValue.sessionHandle = sessionHandle;
            inValue.itemsArray = itemsArray;
            inValue.buyerFilterArray = buyerFilterArray;
            return ((Allegro.servicePort)(this)).doGetPostBuyDataAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetPostBuyFormsDataForBuyersResponse> Allegro.servicePort.doGetPostBuyFormsDataForBuyersAsync(Allegro.doGetPostBuyFormsDataForBuyersRequest request)
        {
            return base.Channel.doGetPostBuyFormsDataForBuyersAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetPostBuyFormsDataForBuyersResponse> doGetPostBuyFormsDataForBuyersAsync(string sessionId, long[] transactionsIdsArray)
        {
            Allegro.doGetPostBuyFormsDataForBuyersRequest inValue = new Allegro.doGetPostBuyFormsDataForBuyersRequest();
            inValue.sessionId = sessionId;
            inValue.transactionsIdsArray = transactionsIdsArray;
            return ((Allegro.servicePort)(this)).doGetPostBuyFormsDataForBuyersAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetPostBuyFormsDataForSellersResponse> Allegro.servicePort.doGetPostBuyFormsDataForSellersAsync(Allegro.doGetPostBuyFormsDataForSellersRequest request)
        {
            return base.Channel.doGetPostBuyFormsDataForSellersAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetPostBuyFormsDataForSellersResponse> doGetPostBuyFormsDataForSellersAsync(string sessionId, long[] transactionsIdsArray)
        {
            Allegro.doGetPostBuyFormsDataForSellersRequest inValue = new Allegro.doGetPostBuyFormsDataForSellersRequest();
            inValue.sessionId = sessionId;
            inValue.transactionsIdsArray = transactionsIdsArray;
            return ((Allegro.servicePort)(this)).doGetPostBuyFormsDataForSellersAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetPostBuyFormsIdsResponse> doGetPostBuyFormsIdsAsync(Allegro.doGetPostBuyFormsIdsRequest request)
        {
            return base.Channel.doGetPostBuyFormsIdsAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetPostBuyItemInfoResponse> Allegro.servicePort.doGetPostBuyItemInfoAsync(Allegro.doGetPostBuyItemInfoRequest request)
        {
            return base.Channel.doGetPostBuyItemInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetPostBuyItemInfoResponse> doGetPostBuyItemInfoAsync(string sessionId, long[] itemIds)
        {
            Allegro.doGetPostBuyItemInfoRequest inValue = new Allegro.doGetPostBuyItemInfoRequest();
            inValue.sessionId = sessionId;
            inValue.itemIds = itemIds;
            return ((Allegro.servicePort)(this)).doGetPostBuyItemInfoAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetRefundsDealsResponse> doGetRefundsDealsAsync(Allegro.doGetRefundsDealsRequest request)
        {
            return base.Channel.doGetRefundsDealsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetRefundsListResponse> doGetRefundsListAsync(Allegro.doGetRefundsListRequest request)
        {
            return base.Channel.doGetRefundsListAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetRefundsReasonsResponse> doGetRefundsReasonsAsync(Allegro.doGetRefundsReasonsRequest request)
        {
            return base.Channel.doGetRefundsReasonsAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetRelatedItemsResponse> Allegro.servicePort.doGetRelatedItemsAsync(Allegro.doGetRelatedItemsRequest request)
        {
            return base.Channel.doGetRelatedItemsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetRelatedItemsResponse> doGetRelatedItemsAsync(string sessionId, long[] itemIds)
        {
            Allegro.doGetRelatedItemsRequest inValue = new Allegro.doGetRelatedItemsRequest();
            inValue.sessionId = sessionId;
            inValue.itemIds = itemIds;
            return ((Allegro.servicePort)(this)).doGetRelatedItemsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetSellFormFieldsForCategoryResponse> Allegro.servicePort.doGetSellFormFieldsForCategoryAsync(Allegro.doGetSellFormFieldsForCategoryRequest request)
        {
            return base.Channel.doGetSellFormFieldsForCategoryAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetSellFormFieldsForCategoryResponse> doGetSellFormFieldsForCategoryAsync(string webapiKey, int countryId, int categoryId)
        {
            Allegro.doGetSellFormFieldsForCategoryRequest inValue = new Allegro.doGetSellFormFieldsForCategoryRequest();
            inValue.webapiKey = webapiKey;
            inValue.countryId = countryId;
            inValue.categoryId = categoryId;
            return ((Allegro.servicePort)(this)).doGetSellFormFieldsForCategoryAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetSessionHandleForWidgetResponse> doGetSessionHandleForWidgetAsync(Allegro.doGetSessionHandleForWidgetRequest request)
        {
            return base.Channel.doGetSessionHandleForWidgetAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetShipmentDataResponse> doGetShipmentDataAsync(Allegro.doGetShipmentDataRequest request)
        {
            return base.Channel.doGetShipmentDataAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetShipmentDataForRelatedItemsResponse> Allegro.servicePort.doGetShipmentDataForRelatedItemsAsync(Allegro.doGetShipmentDataForRelatedItemsRequest request)
        {
            return base.Channel.doGetShipmentDataForRelatedItemsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetShipmentDataForRelatedItemsResponse> doGetShipmentDataForRelatedItemsAsync(string sessionId, long[] itemIds)
        {
            Allegro.doGetShipmentDataForRelatedItemsRequest inValue = new Allegro.doGetShipmentDataForRelatedItemsRequest();
            inValue.sessionId = sessionId;
            inValue.itemIds = itemIds;
            return ((Allegro.servicePort)(this)).doGetShipmentDataForRelatedItemsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetShipmentPriceTypesResponse> Allegro.servicePort.doGetShipmentPriceTypesAsync(Allegro.doGetShipmentPriceTypesRequest request)
        {
            return base.Channel.doGetShipmentPriceTypesAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetShipmentPriceTypesResponse> doGetShipmentPriceTypesAsync(int countryId, string webapiKey)
        {
            Allegro.doGetShipmentPriceTypesRequest inValue = new Allegro.doGetShipmentPriceTypesRequest();
            inValue.countryId = countryId;
            inValue.webapiKey = webapiKey;
            return ((Allegro.servicePort)(this)).doGetShipmentPriceTypesAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetShopsTagsResponse> doGetShopsTagsAsync(Allegro.doGetShopsTagsRequest request)
        {
            return base.Channel.doGetShopsTagsAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetSiteJournalResponse> Allegro.servicePort.doGetSiteJournalAsync(Allegro.doGetSiteJournalRequest request)
        {
            return base.Channel.doGetSiteJournalAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetSiteJournalResponse> doGetSiteJournalAsync(string sessionHandle, long startingPoint, int infoType)
        {
            Allegro.doGetSiteJournalRequest inValue = new Allegro.doGetSiteJournalRequest();
            inValue.sessionHandle = sessionHandle;
            inValue.startingPoint = startingPoint;
            inValue.infoType = infoType;
            return ((Allegro.servicePort)(this)).doGetSiteJournalAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetSiteJournalDealsResponse> Allegro.servicePort.doGetSiteJournalDealsAsync(Allegro.doGetSiteJournalDealsRequest request)
        {
            return base.Channel.doGetSiteJournalDealsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetSiteJournalDealsResponse> doGetSiteJournalDealsAsync(string sessionId, long journalStart)
        {
            Allegro.doGetSiteJournalDealsRequest inValue = new Allegro.doGetSiteJournalDealsRequest();
            inValue.sessionId = sessionId;
            inValue.journalStart = journalStart;
            return ((Allegro.servicePort)(this)).doGetSiteJournalDealsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetSiteJournalDealsInfoResponse> Allegro.servicePort.doGetSiteJournalDealsInfoAsync(Allegro.doGetSiteJournalDealsInfoRequest request)
        {
            return base.Channel.doGetSiteJournalDealsInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetSiteJournalDealsInfoResponse> doGetSiteJournalDealsInfoAsync(string sessionId, long journalStart)
        {
            Allegro.doGetSiteJournalDealsInfoRequest inValue = new Allegro.doGetSiteJournalDealsInfoRequest();
            inValue.sessionId = sessionId;
            inValue.journalStart = journalStart;
            return ((Allegro.servicePort)(this)).doGetSiteJournalDealsInfoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetSiteJournalInfoResponse> Allegro.servicePort.doGetSiteJournalInfoAsync(Allegro.doGetSiteJournalInfoRequest request)
        {
            return base.Channel.doGetSiteJournalInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetSiteJournalInfoResponse> doGetSiteJournalInfoAsync(string sessionHandle, long startingPoint, int infoType)
        {
            Allegro.doGetSiteJournalInfoRequest inValue = new Allegro.doGetSiteJournalInfoRequest();
            inValue.sessionHandle = sessionHandle;
            inValue.startingPoint = startingPoint;
            inValue.infoType = infoType;
            return ((Allegro.servicePort)(this)).doGetSiteJournalInfoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetStatesInfoResponse> Allegro.servicePort.doGetStatesInfoAsync(Allegro.doGetStatesInfoRequest request)
        {
            return base.Channel.doGetStatesInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetStatesInfoResponse> doGetStatesInfoAsync(int countryCode, string webapiKey)
        {
            Allegro.doGetStatesInfoRequest inValue = new Allegro.doGetStatesInfoRequest();
            inValue.countryCode = countryCode;
            inValue.webapiKey = webapiKey;
            return ((Allegro.servicePort)(this)).doGetStatesInfoAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetSystemTimeResponse> Allegro.servicePort.doGetSystemTimeAsync(Allegro.doGetSystemTimeRequest request)
        {
            return base.Channel.doGetSystemTimeAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetSystemTimeResponse> doGetSystemTimeAsync(int countryId, string webapiKey)
        {
            Allegro.doGetSystemTimeRequest inValue = new Allegro.doGetSystemTimeRequest();
            inValue.countryId = countryId;
            inValue.webapiKey = webapiKey;
            return ((Allegro.servicePort)(this)).doGetSystemTimeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetTransactionsIDsResponse> Allegro.servicePort.doGetTransactionsIDsAsync(Allegro.doGetTransactionsIDsRequest request)
        {
            return base.Channel.doGetTransactionsIDsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetTransactionsIDsResponse> doGetTransactionsIDsAsync(string sessionHandle, long[] itemsIdArray, string userRole, long[] shipmentIdArray)
        {
            Allegro.doGetTransactionsIDsRequest inValue = new Allegro.doGetTransactionsIDsRequest();
            inValue.sessionHandle = sessionHandle;
            inValue.itemsIdArray = itemsIdArray;
            inValue.userRole = userRole;
            inValue.shipmentIdArray = shipmentIdArray;
            return ((Allegro.servicePort)(this)).doGetTransactionsIDsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetUserIDResponse> Allegro.servicePort.doGetUserIDAsync(Allegro.doGetUserIDRequest request)
        {
            return base.Channel.doGetUserIDAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetUserIDResponse> doGetUserIDAsync(int countryId, string userLogin, string userEmail, string webapiKey)
        {
            Allegro.doGetUserIDRequest inValue = new Allegro.doGetUserIDRequest();
            inValue.countryId = countryId;
            inValue.userLogin = userLogin;
            inValue.userEmail = userEmail;
            inValue.webapiKey = webapiKey;
            return ((Allegro.servicePort)(this)).doGetUserIDAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doGetUserLoginResponse> Allegro.servicePort.doGetUserLoginAsync(Allegro.doGetUserLoginRequest request)
        {
            return base.Channel.doGetUserLoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doGetUserLoginResponse> doGetUserLoginAsync(int countryId, int userId, string webapiKey)
        {
            Allegro.doGetUserLoginRequest inValue = new Allegro.doGetUserLoginRequest();
            inValue.countryId = countryId;
            inValue.userId = userId;
            inValue.webapiKey = webapiKey;
            return ((Allegro.servicePort)(this)).doGetUserLoginAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Allegro.doLoginResponse> doLoginAsync(Allegro.doLoginRequest request)
        {
            return base.Channel.doLoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doLoginEncResponse> doLoginEncAsync(Allegro.doLoginEncRequest request)
        {
            return base.Channel.doLoginEncAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doLoginWithAccessTokenResponse> doLoginWithAccessTokenAsync(Allegro.doLoginWithAccessTokenRequest request)
        {
            return base.Channel.doLoginWithAccessTokenAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doMyAccount2Response> Allegro.servicePort.doMyAccount2Async(Allegro.doMyAccount2Request request)
        {
            return base.Channel.doMyAccount2Async(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doMyAccount2Response> doMyAccount2Async(string sessionHandle, string accountType, int offset, long[] itemsArray, int limit)
        {
            Allegro.doMyAccount2Request inValue = new Allegro.doMyAccount2Request();
            inValue.sessionHandle = sessionHandle;
            inValue.accountType = accountType;
            inValue.offset = offset;
            inValue.itemsArray = itemsArray;
            inValue.limit = limit;
            return ((Allegro.servicePort)(this)).doMyAccount2Async(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doMyAccountItemsCountResponse> Allegro.servicePort.doMyAccountItemsCountAsync(Allegro.doMyAccountItemsCountRequest request)
        {
            return base.Channel.doMyAccountItemsCountAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doMyAccountItemsCountResponse> doMyAccountItemsCountAsync(string sessionHandle, string accountType, long[] itemsArray)
        {
            Allegro.doMyAccountItemsCountRequest inValue = new Allegro.doMyAccountItemsCountRequest();
            inValue.sessionHandle = sessionHandle;
            inValue.accountType = accountType;
            inValue.itemsArray = itemsArray;
            return ((Allegro.servicePort)(this)).doMyAccountItemsCountAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doMyBillingResponse> Allegro.servicePort.doMyBillingAsync(Allegro.doMyBillingRequest request)
        {
            return base.Channel.doMyBillingAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doMyBillingResponse> doMyBillingAsync(string sessionHandle)
        {
            Allegro.doMyBillingRequest inValue = new Allegro.doMyBillingRequest();
            inValue.sessionHandle = sessionHandle;
            return ((Allegro.servicePort)(this)).doMyBillingAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Allegro.doMyBillingItemResponse> doMyBillingItemAsync(Allegro.doMyBillingItemRequest request)
        {
            return base.Channel.doMyBillingItemAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doMyContactResponse> Allegro.servicePort.doMyContactAsync(Allegro.doMyContactRequest request)
        {
            return base.Channel.doMyContactAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doMyContactResponse> doMyContactAsync(string sessionHandle, long[] auctionIdList, int offset, int desc)
        {
            Allegro.doMyContactRequest inValue = new Allegro.doMyContactRequest();
            inValue.sessionHandle = sessionHandle;
            inValue.auctionIdList = auctionIdList;
            inValue.offset = offset;
            inValue.desc = desc;
            return ((Allegro.servicePort)(this)).doMyContactAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Allegro.doNewAuctionExtResponse> doNewAuctionExtAsync(Allegro.doNewAuctionExtRequest request)
        {
            return base.Channel.doNewAuctionExtAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doQueryAllSysStatusResponse> Allegro.servicePort.doQueryAllSysStatusAsync(Allegro.doQueryAllSysStatusRequest request)
        {
            return base.Channel.doQueryAllSysStatusAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doQueryAllSysStatusResponse> doQueryAllSysStatusAsync(int countryId, string webapiKey)
        {
            Allegro.doQueryAllSysStatusRequest inValue = new Allegro.doQueryAllSysStatusRequest();
            inValue.countryId = countryId;
            inValue.webapiKey = webapiKey;
            return ((Allegro.servicePort)(this)).doQueryAllSysStatusAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Allegro.doQuerySysStatusResponse> doQuerySysStatusAsync(Allegro.doQuerySysStatusRequest request)
        {
            return base.Channel.doQuerySysStatusAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doRemoveFromBlackListResponse> Allegro.servicePort.doRemoveFromBlackListAsync(Allegro.doRemoveFromBlackListRequest request)
        {
            return base.Channel.doRemoveFromBlackListAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doRemoveFromBlackListResponse> doRemoveFromBlackListAsync(string sessionHandle, long[] usersIdArray)
        {
            Allegro.doRemoveFromBlackListRequest inValue = new Allegro.doRemoveFromBlackListRequest();
            inValue.sessionHandle = sessionHandle;
            inValue.usersIdArray = usersIdArray;
            return ((Allegro.servicePort)(this)).doRemoveFromBlackListAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doRequestCancelBidResponse> Allegro.servicePort.doRequestCancelBidAsync(Allegro.doRequestCancelBidRequest request)
        {
            return base.Channel.doRequestCancelBidAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doRequestCancelBidResponse> doRequestCancelBidAsync(string sessionHandle, long requestItemId, string requestCancelReason)
        {
            Allegro.doRequestCancelBidRequest inValue = new Allegro.doRequestCancelBidRequest();
            inValue.sessionHandle = sessionHandle;
            inValue.requestItemId = requestItemId;
            inValue.requestCancelReason = requestCancelReason;
            return ((Allegro.servicePort)(this)).doRequestCancelBidAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doRequestPayoutResponse> Allegro.servicePort.doRequestPayoutAsync(Allegro.doRequestPayoutRequest request)
        {
            return base.Channel.doRequestPayoutAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doRequestPayoutResponse> doRequestPayoutAsync(string sessionId)
        {
            Allegro.doRequestPayoutRequest inValue = new Allegro.doRequestPayoutRequest();
            inValue.sessionId = sessionId;
            return ((Allegro.servicePort)(this)).doRequestPayoutAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doRequestSurchargeResponse> Allegro.servicePort.doRequestSurchargeAsync(Allegro.doRequestSurchargeRequest request)
        {
            return base.Channel.doRequestSurchargeAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doRequestSurchargeResponse> doRequestSurchargeAsync(string sessionHandle, long transactionId, float surchargeValue, string surchargeMessageToBuyer)
        {
            Allegro.doRequestSurchargeRequest inValue = new Allegro.doRequestSurchargeRequest();
            inValue.sessionHandle = sessionHandle;
            inValue.transactionId = transactionId;
            inValue.surchargeValue = surchargeValue;
            inValue.surchargeMessageToBuyer = surchargeMessageToBuyer;
            return ((Allegro.servicePort)(this)).doRequestSurchargeAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Allegro.doSellSomeAgainResponse> doSellSomeAgainAsync(Allegro.doSellSomeAgainRequest request)
        {
            return base.Channel.doSellSomeAgainAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doSellSomeAgainInShopResponse> doSellSomeAgainInShopAsync(Allegro.doSellSomeAgainInShopRequest request)
        {
            return base.Channel.doSellSomeAgainInShopAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doSendEmailToUserResponse> doSendEmailToUserAsync(Allegro.doSendEmailToUserRequest request)
        {
            return base.Channel.doSendEmailToUserAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doSendPostBuyFormResponse> Allegro.servicePort.doSendPostBuyFormAsync(Allegro.doSendPostBuyFormRequest request)
        {
            return base.Channel.doSendPostBuyFormAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doSendPostBuyFormResponse> doSendPostBuyFormAsync(string sessionId, Allegro.NewPostBuyFormSellerStruct[] newPostBuyFormSeller, Allegro.NewPostBuyFormCommonStruct newPostBuyFormCommon)
        {
            Allegro.doSendPostBuyFormRequest inValue = new Allegro.doSendPostBuyFormRequest();
            inValue.sessionId = sessionId;
            inValue.newPostBuyFormSeller = newPostBuyFormSeller;
            inValue.newPostBuyFormCommon = newPostBuyFormCommon;
            return ((Allegro.servicePort)(this)).doSendPostBuyFormAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doSendRefundFormResponse> Allegro.servicePort.doSendRefundFormAsync(Allegro.doSendRefundFormRequest request)
        {
            return base.Channel.doSendRefundFormAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doSendRefundFormResponse> doSendRefundFormAsync(string sessionId, int dealId, int reasonId, int refundQuantity)
        {
            Allegro.doSendRefundFormRequest inValue = new Allegro.doSendRefundFormRequest();
            inValue.sessionId = sessionId;
            inValue.dealId = dealId;
            inValue.reasonId = reasonId;
            inValue.refundQuantity = refundQuantity;
            return ((Allegro.servicePort)(this)).doSendRefundFormAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doSetFreeDeliveryAmountResponse> Allegro.servicePort.doSetFreeDeliveryAmountAsync(Allegro.doSetFreeDeliveryAmountRequest request)
        {
            return base.Channel.doSetFreeDeliveryAmountAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doSetFreeDeliveryAmountResponse> doSetFreeDeliveryAmountAsync(string sessionId, int activeFlag, float freeDeliveryAmount)
        {
            Allegro.doSetFreeDeliveryAmountRequest inValue = new Allegro.doSetFreeDeliveryAmountRequest();
            inValue.sessionId = sessionId;
            inValue.activeFlag = activeFlag;
            inValue.freeDeliveryAmount = freeDeliveryAmount;
            return ((Allegro.servicePort)(this)).doSetFreeDeliveryAmountAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Allegro.doSetShipmentPriceTypeResponse> Allegro.servicePort.doSetShipmentPriceTypeAsync(Allegro.doSetShipmentPriceTypeRequest request)
        {
            return base.Channel.doSetShipmentPriceTypeAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doSetShipmentPriceTypeResponse> doSetShipmentPriceTypeAsync(string sessionId, int shipmentPriceTypeId)
        {
            Allegro.doSetShipmentPriceTypeRequest inValue = new Allegro.doSetShipmentPriceTypeRequest();
            inValue.sessionId = sessionId;
            inValue.shipmentPriceTypeId = shipmentPriceTypeId;
            return ((Allegro.servicePort)(this)).doSetShipmentPriceTypeAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<Allegro.doShowItemInfoExtResponse> doShowItemInfoExtAsync(Allegro.doShowItemInfoExtRequest request)
        {
            return base.Channel.doShowItemInfoExtAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doShowUserResponse> doShowUserAsync(Allegro.doShowUserRequest request)
        {
            return base.Channel.doShowUserAsync(request);
        }
        
        public System.Threading.Tasks.Task<Allegro.doVerifyItemResponse> doVerifyItemAsync(Allegro.doVerifyItemRequest request)
        {
            return base.Channel.doVerifyItemAsync(request);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.servicePort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Nie można znaleźć punktu końcowego o nazwie „{0}”.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.servicePort))
            {
                return new System.ServiceModel.EndpointAddress("https://webapi.allegro.pl/service.php");
            }
            throw new System.InvalidOperationException(string.Format("Nie można znaleźć punktu końcowego o nazwie „{0}”.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return servicePortClient.GetBindingForEndpoint(EndpointConfiguration.servicePort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return servicePortClient.GetEndpointAddress(EndpointConfiguration.servicePort);
        }
        
        public enum EndpointConfiguration
        {
            
            servicePort,
        }
    }
}
