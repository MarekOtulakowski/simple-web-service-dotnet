// ************************************************************************ //
// The types declared in this file were generated from data read from the
// WSDL File described below:
// WSDL     : http://localhost:100/WebService.asmx?WSDL
//  >Import : http://localhost:100/WebService.asmx?WSDL>0
// Encoding : utf-8
// Version  : 1.0
// (2012-11-20 19:09:24 - - $Rev: 52705 $)
// ************************************************************************ //

unit WebService;

interface

uses InvokeRegistry, SOAPHTTPClient, Types, XSBuiltIns;

const
  IS_REF  = $0080;


type

  // ************************************************************************ //
  // The following types, referred to in the WSDL document are not being represented
  // in this file. They are either aliases[@] of other types represented or were referred
  // to but never[!] declared in the document. The types from the latter category
  // typically map to predefined/known XML or Embarcadero types; however, they could also 
  // indicate incorrect WSDL documents that failed to declare or import a schema type.
  // ************************************************************************ //
  // !:int             - "http://www.w3.org/2001/XMLSchema"[Gbl]



  // ************************************************************************ //
  // Namespace : makoff.webService
  // soapAction: makoff.webService/%operationName%
  // transport : http://schemas.xmlsoap.org/soap/http
  // style     : document
  // use       : literal
  // binding   : WebServiceSoap
  // service   : WebService
  // port      : WebServiceSoap
  // URL       : http://localhost:100/WebService.asmx
  // ************************************************************************ //
  WebServiceSoap = interface(IInvokable)
  ['{13CC2C10-9869-0538-0FDE-7AC8F20A9B6B}']
    function  Dodaj(const x: Integer; const y: Integer): Integer; stdcall;
    function  Odejmij(const x: Integer; const y: Integer): Integer; stdcall;
    function  Pomnoz(const x: Integer; const y: Integer): Integer; stdcall;
    function  Podziel(const x: Integer; const y: Integer): Integer; stdcall;
  end;

function GetWebServiceSoap(UseWSDL: Boolean=System.False; Addr: string=''; HTTPRIO: THTTPRIO = nil): WebServiceSoap;


implementation
  uses SysUtils;

function GetWebServiceSoap(UseWSDL: Boolean; Addr: string; HTTPRIO: THTTPRIO): WebServiceSoap;
const
  defWSDL = 'http://localhost:100/WebService.asmx?WSDL';
  defURL  = 'http://localhost:100/WebService.asmx';
  defSvc  = 'WebService';
  defPrt  = 'WebServiceSoap';
var
  RIO: THTTPRIO;
begin
  Result := nil;
  if (Addr = '') then
  begin
    if UseWSDL then
      Addr := defWSDL
    else
      Addr := defURL;
  end;
  if HTTPRIO = nil then
    RIO := THTTPRIO.Create(nil)
  else
    RIO := HTTPRIO;
  try
    Result := (RIO as WebServiceSoap);
    if UseWSDL then
    begin
      RIO.WSDLLocation := Addr;
      RIO.Service := defSvc;
      RIO.Port := defPrt;
    end else
      RIO.URL := Addr;
  finally
    if (Result = nil) and (HTTPRIO = nil) then
      RIO.Free;
  end;
end;


initialization
  { WebServiceSoap }
  InvRegistry.RegisterInterface(TypeInfo(WebServiceSoap), 'makoff.webService', 'utf-8');
  InvRegistry.RegisterDefaultSOAPAction(TypeInfo(WebServiceSoap), 'makoff.webService/%operationName%');
  InvRegistry.RegisterInvokeOptions(TypeInfo(WebServiceSoap), ioDocument);
  { WebServiceSoap.Dodaj }
  InvRegistry.RegisterMethodInfo(TypeInfo(WebServiceSoap), 'Dodaj', '',
                                 '[ReturnName="DodajResult"]');
  { WebServiceSoap.Odejmij }
  InvRegistry.RegisterMethodInfo(TypeInfo(WebServiceSoap), 'Odejmij', '',
                                 '[ReturnName="OdejmijResult"]');
  { WebServiceSoap.Pomnoz }
  InvRegistry.RegisterMethodInfo(TypeInfo(WebServiceSoap), 'Pomnoz', '',
                                 '[ReturnName="PomnozResult"]');
  { WebServiceSoap.Podziel }
  InvRegistry.RegisterMethodInfo(TypeInfo(WebServiceSoap), 'Podziel', '',
                                 '[ReturnName="PodzielResult"]');

end.