program Project_ClientWebService_Delphi;

uses
  Vcl.Forms,
  form_glowna in 'form_glowna.pas' {F_Glowna},
  WebService in 'WebService.pas';

{$R *.res}

begin
  Application.Initialize;
  Application.MainFormOnTaskbar := True;
  Application.CreateForm(TF_Glowna, F_Glowna);
  Application.Run;
end.
