object F_Glowna: TF_Glowna
  Left = 0
  Top = 0
  BorderStyle = bsToolWindow
  Caption = 'Client WebService Delphi'
  ClientHeight = 218
  ClientWidth = 327
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'Tahoma'
  Font.Style = []
  OldCreateOrder = False
  OnCreate = FormCreate
  PixelsPerInch = 96
  TextHeight = 13
  object L_rownaSie: TLabel
    Left = 224
    Top = 20
    Width = 8
    Height = 13
    Caption = '='
  end
  object E_x: TEdit
    Left = 16
    Top = 16
    Width = 73
    Height = 21
    TabOrder = 0
    Text = '123'
  end
  object CB_operacja: TComboBox
    Left = 95
    Top = 16
    Width = 42
    Height = 21
    Style = csDropDownList
    TabOrder = 1
    Items.Strings = (
      '+'
      '-'
      '*'
      '/')
  end
  object E_y: TEdit
    Left = 143
    Top = 16
    Width = 73
    Height = 21
    TabOrder = 2
    Text = '345'
  end
  object E_wynik: TEdit
    Left = 239
    Top = 16
    Width = 73
    Height = 21
    Enabled = False
    TabOrder = 3
  end
  object B_wylicz: TButton
    Left = 16
    Top = 50
    Width = 296
    Height = 25
    Caption = 'Wylicz'
    TabOrder = 4
    OnClick = B_wyliczClick
  end
  object E_bledy: TEdit
    Left = 16
    Top = 81
    Width = 296
    Height = 120
    AutoSize = False
    Enabled = False
    TabOrder = 5
  end
end
