unit form_glowna;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.Variants, System.Classes, Vcl.Graphics,
  Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls;

type
  TF_Glowna = class(TForm)
    E_x: TEdit;
    CB_operacja: TComboBox;
    E_y: TEdit;
    L_rownaSie: TLabel;
    E_wynik: TEdit;
    B_wylicz: TButton;
    E_bledy: TEdit;
    procedure FormCreate(Sender: TObject);
    procedure B_wyliczClick(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  F_Glowna: TF_Glowna;

implementation
uses WebService;
var
  KomunikatBledu : string;
  wss : WebService.WebServiceSoap;
{$R *.dfm}

function Walidacja(x : string; y : string): Boolean;
begin
    KomunikatBledu := '';
   try
   begin
      if (Trim(x) = '') then
      begin
         KomunikatBledu := 'Pierwsze pole jest puste!';
         result := false;
      end;
      if (Trim(y) = '') then
      begin
         KomunikatBledu := 'Drugie pole jest puste!';
         result := false;
      end;

      StrToInt(x);
      StrToInt(y);
      result := true;
   end
   except
    begin
      KomunikatBledu := 'Wartoœci pól pierwszego i drugiego s¹ nieprawid³owe!';
      result := false;
    end
   end;
end;

procedure TF_Glowna.B_wyliczClick(Sender: TObject);
var
  wynik : Integer;
begin
  if Walidacja(E_x.Text, E_y.Text) then
  begin
    if (CB_operacja.Text = '+') then
    begin
      E_wynik.Text := IntToStr(wss.Dodaj(StrToInt(E_x.Text), StrToInt(E_y.Text)));
    end
    else if (CB_operacja.Text = '-') then
    begin
      E_wynik.Text := IntToStr(wss.Odejmij(StrToInt(E_x.Text), StrToInt(E_y.Text)));
    end
    else if (CB_operacja.Text = '*') then
    begin
      E_wynik.Text := IntToStr(wss.Pomnoz(StrToInt(E_x.Text), StrToInt(E_y.Text)));
    end
    else if (CB_operacja.Text = '/') then
    begin
      try
         E_wynik.Text := IntToStr(wss.Podziel(StrToInt(E_x.Text), StrToInt(E_y.Text)));
      except
         on E : Exception do
         begin
            E_bledy.Text := 'Exception message = ' + E.Message;
         end;
      end;
    end
  end
  else
    begin
      E_bledy.Text := KomunikatBledu;
    end
end;


procedure TF_Glowna.FormCreate(Sender: TObject);
begin
  CB_operacja.ItemIndex := 0;
  wss := GetWebServiceSoap(true, '', nil);
end;

end.
