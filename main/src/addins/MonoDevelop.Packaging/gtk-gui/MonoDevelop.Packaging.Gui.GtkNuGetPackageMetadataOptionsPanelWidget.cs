
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.Packaging.Gui
{
	public partial class GtkNuGetPackageMetadataOptionsPanelWidget
	{
		private global::Gtk.Table mainTable;

		private global::Gtk.Label packageAuthorsLabel;

		private global::Gtk.Entry packageAuthorsTextBox;

		private global::Gtk.Label packageCopyrightLabel;

		private global::Gtk.Entry packageCopyrightTextBox;

		private global::Gtk.VBox packageDescriptionLabelVBox;

		private global::Gtk.Label packageDescriptionLabel;

		private global::Gtk.EventBox packageDescriptionLabelPaddingEventBox;

		private global::Gtk.ScrolledWindow packageDescriptionScrolledWindow;

		private global::Gtk.TextView packageDescriptionTextView;

		private global::Gtk.CheckButton packageDevelopmentDependencyCheckBox;

		private global::Gtk.Label packageDevelopmentDependencyLabel;

		private global::Gtk.Label packageIconUrlLabel;

		private global::Gtk.Entry packageIconUrlTextBox;

		private global::Gtk.Label packageIdLabel;

		private global::Gtk.Entry packageIdTextBox;

		private global::Gtk.Label packageLanguageLabel;

		private global::Gtk.Entry packageLanguageTextBox;

		private global::Gtk.Label packageLicenseUrlLabel;

		private global::Gtk.Entry packageLicenseUrlTextBox;

		private global::Gtk.Label packageOwnersLabel;

		private global::Gtk.Entry packageOwnersTextBox;

		private global::Gtk.Label packageProjectUrlLabel;

		private global::Gtk.Entry packageProjectUrlTextBox;

		private global::Gtk.VBox packageReleaseNotesLabelVBox;

		private global::Gtk.Label packageReleaseNotesLabel;

		private global::Gtk.EventBox packageReleaseNotesLabelPaddingEventBox;

		private global::Gtk.ScrolledWindow packageReleaseNotesScrolledWindow;

		private global::Gtk.TextView packageReleaseNotesTextView;

		private global::Gtk.CheckButton packageRequireLicenseAcceptanceCheckBox;

		private global::Gtk.Label packageRequireLicenseAcceptanceLabel;

		private global::Gtk.Label packageSummaryLabel;

		private global::Gtk.Entry packageSummaryTextBox;

		private global::Gtk.Label packageTagsLabel;

		private global::Gtk.Entry packageTagsTextBox;

		private global::Gtk.Label packageTitleLabel;

		private global::Gtk.Entry packageTitleTextBox;

		private global::Gtk.Label packageVersionLabel;

		private global::Gtk.Entry packageVersionTextBox;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget MonoDevelop.Packaging.Gui.GtkNuGetPackageMetadataOptionsPanelWidget
			global::Stetic.BinContainer.Attach(this);
			this.Name = "MonoDevelop.Packaging.Gui.GtkNuGetPackageMetadataOptionsPanelWidget";
			// Container child MonoDevelop.Packaging.Gui.GtkNuGetPackageMetadataOptionsPanelWidget.Gtk.Container+ContainerChild
			this.mainTable = new global::Gtk.Table(((uint)(16)), ((uint)(3)), false);
			this.mainTable.Name = "mainTable";
			this.mainTable.RowSpacing = ((uint)(6));
			this.mainTable.ColumnSpacing = ((uint)(6));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageAuthorsLabel = new global::Gtk.Label();
			this.packageAuthorsLabel.Name = "packageAuthorsLabel";
			this.packageAuthorsLabel.Xalign = 0F;
			this.packageAuthorsLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Authors:");
			this.mainTable.Add(this.packageAuthorsLabel);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageAuthorsLabel]));
			w1.TopAttach = ((uint)(2));
			w1.BottomAttach = ((uint)(3));
			w1.XOptions = ((global::Gtk.AttachOptions)(4));
			w1.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageAuthorsTextBox = new global::Gtk.Entry();
			this.packageAuthorsTextBox.CanFocus = true;
			this.packageAuthorsTextBox.Name = "packageAuthorsTextBox";
			this.packageAuthorsTextBox.IsEditable = true;
			this.packageAuthorsTextBox.InvisibleChar = '●';
			this.mainTable.Add(this.packageAuthorsTextBox);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageAuthorsTextBox]));
			w2.TopAttach = ((uint)(2));
			w2.BottomAttach = ((uint)(3));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageCopyrightLabel = new global::Gtk.Label();
			this.packageCopyrightLabel.Name = "packageCopyrightLabel";
			this.packageCopyrightLabel.Xalign = 0F;
			this.packageCopyrightLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Copyright:");
			this.mainTable.Add(this.packageCopyrightLabel);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageCopyrightLabel]));
			w3.TopAttach = ((uint)(4));
			w3.BottomAttach = ((uint)(5));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageCopyrightTextBox = new global::Gtk.Entry();
			this.packageCopyrightTextBox.CanFocus = true;
			this.packageCopyrightTextBox.Name = "packageCopyrightTextBox";
			this.packageCopyrightTextBox.IsEditable = true;
			this.packageCopyrightTextBox.InvisibleChar = '●';
			this.mainTable.Add(this.packageCopyrightTextBox);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageCopyrightTextBox]));
			w4.TopAttach = ((uint)(4));
			w4.BottomAttach = ((uint)(5));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageDescriptionLabelVBox = new global::Gtk.VBox();
			this.packageDescriptionLabelVBox.Name = "packageDescriptionLabelVBox";
			this.packageDescriptionLabelVBox.Spacing = 6;
			// Container child packageDescriptionLabelVBox.Gtk.Box+BoxChild
			this.packageDescriptionLabel = new global::Gtk.Label();
			this.packageDescriptionLabel.Name = "packageDescriptionLabel";
			this.packageDescriptionLabel.Xalign = 0F;
			this.packageDescriptionLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Description:");
			this.packageDescriptionLabelVBox.Add(this.packageDescriptionLabel);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.packageDescriptionLabelVBox[this.packageDescriptionLabel]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Container child packageDescriptionLabelVBox.Gtk.Box+BoxChild
			this.packageDescriptionLabelPaddingEventBox = new global::Gtk.EventBox();
			this.packageDescriptionLabelPaddingEventBox.Name = "packageDescriptionLabelPaddingEventBox";
			this.packageDescriptionLabelVBox.Add(this.packageDescriptionLabelPaddingEventBox);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.packageDescriptionLabelVBox[this.packageDescriptionLabelPaddingEventBox]));
			w6.Position = 1;
			this.mainTable.Add(this.packageDescriptionLabelVBox);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageDescriptionLabelVBox]));
			w7.TopAttach = ((uint)(6));
			w7.BottomAttach = ((uint)(7));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageDescriptionScrolledWindow = new global::Gtk.ScrolledWindow();
			this.packageDescriptionScrolledWindow.Name = "packageDescriptionScrolledWindow";
			this.packageDescriptionScrolledWindow.HscrollbarPolicy = ((global::Gtk.PolicyType)(2));
			this.packageDescriptionScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child packageDescriptionScrolledWindow.Gtk.Container+ContainerChild
			this.packageDescriptionTextView = new global::Gtk.TextView();
			this.packageDescriptionTextView.CanFocus = true;
			this.packageDescriptionTextView.Name = "packageDescriptionTextView";
			this.packageDescriptionTextView.AcceptsTab = false;
			this.packageDescriptionTextView.WrapMode = ((global::Gtk.WrapMode)(2));
			this.packageDescriptionScrolledWindow.Add(this.packageDescriptionTextView);
			this.mainTable.Add(this.packageDescriptionScrolledWindow);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageDescriptionScrolledWindow]));
			w9.TopAttach = ((uint)(6));
			w9.BottomAttach = ((uint)(7));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageDevelopmentDependencyCheckBox = new global::Gtk.CheckButton();
			this.packageDevelopmentDependencyCheckBox.CanFocus = true;
			this.packageDevelopmentDependencyCheckBox.Name = "packageDevelopmentDependencyCheckBox";
			this.packageDevelopmentDependencyCheckBox.Label = "";
			this.packageDevelopmentDependencyCheckBox.DrawIndicator = true;
			this.packageDevelopmentDependencyCheckBox.UseUnderline = true;
			this.packageDevelopmentDependencyCheckBox.Xalign = 0F;
			this.mainTable.Add(this.packageDevelopmentDependencyCheckBox);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageDevelopmentDependencyCheckBox]));
			w10.TopAttach = ((uint)(12));
			w10.BottomAttach = ((uint)(13));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageDevelopmentDependencyLabel = new global::Gtk.Label();
			this.packageDevelopmentDependencyLabel.Name = "packageDevelopmentDependencyLabel";
			this.packageDevelopmentDependencyLabel.Xalign = 0F;
			this.packageDevelopmentDependencyLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Development Dependency:");
			this.mainTable.Add(this.packageDevelopmentDependencyLabel);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageDevelopmentDependencyLabel]));
			w11.TopAttach = ((uint)(12));
			w11.BottomAttach = ((uint)(13));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageIconUrlLabel = new global::Gtk.Label();
			this.packageIconUrlLabel.Name = "packageIconUrlLabel";
			this.packageIconUrlLabel.Xalign = 0F;
			this.packageIconUrlLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Icon Url:");
			this.mainTable.Add(this.packageIconUrlLabel);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageIconUrlLabel]));
			w12.TopAttach = ((uint)(9));
			w12.BottomAttach = ((uint)(10));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageIconUrlTextBox = new global::Gtk.Entry();
			this.packageIconUrlTextBox.CanFocus = true;
			this.packageIconUrlTextBox.Name = "packageIconUrlTextBox";
			this.packageIconUrlTextBox.IsEditable = true;
			this.packageIconUrlTextBox.InvisibleChar = '●';
			this.mainTable.Add(this.packageIconUrlTextBox);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageIconUrlTextBox]));
			w13.TopAttach = ((uint)(9));
			w13.BottomAttach = ((uint)(10));
			w13.LeftAttach = ((uint)(1));
			w13.RightAttach = ((uint)(2));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageIdLabel = new global::Gtk.Label();
			this.packageIdLabel.Name = "packageIdLabel";
			this.packageIdLabel.Xalign = 0F;
			this.packageIdLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Id:");
			this.mainTable.Add(this.packageIdLabel);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageIdLabel]));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageIdTextBox = new global::Gtk.Entry();
			this.packageIdTextBox.CanFocus = true;
			this.packageIdTextBox.Name = "packageIdTextBox";
			this.packageIdTextBox.IsEditable = true;
			this.packageIdTextBox.InvisibleChar = '●';
			this.mainTable.Add(this.packageIdTextBox);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageIdTextBox]));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageLanguageLabel = new global::Gtk.Label();
			this.packageLanguageLabel.Name = "packageLanguageLabel";
			this.packageLanguageLabel.Xalign = 0F;
			this.packageLanguageLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Language:");
			this.mainTable.Add(this.packageLanguageLabel);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageLanguageLabel]));
			w16.TopAttach = ((uint)(14));
			w16.BottomAttach = ((uint)(15));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageLanguageTextBox = new global::Gtk.Entry();
			this.packageLanguageTextBox.CanFocus = true;
			this.packageLanguageTextBox.Name = "packageLanguageTextBox";
			this.packageLanguageTextBox.IsEditable = true;
			this.packageLanguageTextBox.InvisibleChar = '●';
			this.mainTable.Add(this.packageLanguageTextBox);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageLanguageTextBox]));
			w17.TopAttach = ((uint)(14));
			w17.BottomAttach = ((uint)(15));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageLicenseUrlLabel = new global::Gtk.Label();
			this.packageLicenseUrlLabel.Name = "packageLicenseUrlLabel";
			this.packageLicenseUrlLabel.Xalign = 0F;
			this.packageLicenseUrlLabel.LabelProp = global::Mono.Unix.Catalog.GetString("License Url:");
			this.mainTable.Add(this.packageLicenseUrlLabel);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageLicenseUrlLabel]));
			w18.TopAttach = ((uint)(10));
			w18.BottomAttach = ((uint)(11));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageLicenseUrlTextBox = new global::Gtk.Entry();
			this.packageLicenseUrlTextBox.CanFocus = true;
			this.packageLicenseUrlTextBox.Name = "packageLicenseUrlTextBox";
			this.packageLicenseUrlTextBox.IsEditable = true;
			this.packageLicenseUrlTextBox.InvisibleChar = '●';
			this.mainTable.Add(this.packageLicenseUrlTextBox);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageLicenseUrlTextBox]));
			w19.TopAttach = ((uint)(10));
			w19.BottomAttach = ((uint)(11));
			w19.LeftAttach = ((uint)(1));
			w19.RightAttach = ((uint)(2));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageOwnersLabel = new global::Gtk.Label();
			this.packageOwnersLabel.Name = "packageOwnersLabel";
			this.packageOwnersLabel.Xalign = 0F;
			this.packageOwnersLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Owners:");
			this.mainTable.Add(this.packageOwnersLabel);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageOwnersLabel]));
			w20.TopAttach = ((uint)(3));
			w20.BottomAttach = ((uint)(4));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageOwnersTextBox = new global::Gtk.Entry();
			this.packageOwnersTextBox.CanFocus = true;
			this.packageOwnersTextBox.Name = "packageOwnersTextBox";
			this.packageOwnersTextBox.IsEditable = true;
			this.packageOwnersTextBox.InvisibleChar = '●';
			this.mainTable.Add(this.packageOwnersTextBox);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageOwnersTextBox]));
			w21.TopAttach = ((uint)(3));
			w21.BottomAttach = ((uint)(4));
			w21.LeftAttach = ((uint)(1));
			w21.RightAttach = ((uint)(2));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageProjectUrlLabel = new global::Gtk.Label();
			this.packageProjectUrlLabel.Name = "packageProjectUrlLabel";
			this.packageProjectUrlLabel.Xalign = 0F;
			this.packageProjectUrlLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Project Url:");
			this.mainTable.Add(this.packageProjectUrlLabel);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageProjectUrlLabel]));
			w22.TopAttach = ((uint)(8));
			w22.BottomAttach = ((uint)(9));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageProjectUrlTextBox = new global::Gtk.Entry();
			this.packageProjectUrlTextBox.CanFocus = true;
			this.packageProjectUrlTextBox.Name = "packageProjectUrlTextBox";
			this.packageProjectUrlTextBox.IsEditable = true;
			this.packageProjectUrlTextBox.InvisibleChar = '●';
			this.mainTable.Add(this.packageProjectUrlTextBox);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageProjectUrlTextBox]));
			w23.TopAttach = ((uint)(8));
			w23.BottomAttach = ((uint)(9));
			w23.LeftAttach = ((uint)(1));
			w23.RightAttach = ((uint)(2));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageReleaseNotesLabelVBox = new global::Gtk.VBox();
			this.packageReleaseNotesLabelVBox.Name = "packageReleaseNotesLabelVBox";
			this.packageReleaseNotesLabelVBox.Spacing = 6;
			// Container child packageReleaseNotesLabelVBox.Gtk.Box+BoxChild
			this.packageReleaseNotesLabel = new global::Gtk.Label();
			this.packageReleaseNotesLabel.Name = "packageReleaseNotesLabel";
			this.packageReleaseNotesLabel.Xalign = 0F;
			this.packageReleaseNotesLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Release Notes:");
			this.packageReleaseNotesLabelVBox.Add(this.packageReleaseNotesLabel);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.packageReleaseNotesLabelVBox[this.packageReleaseNotesLabel]));
			w24.Position = 0;
			w24.Expand = false;
			w24.Fill = false;
			// Container child packageReleaseNotesLabelVBox.Gtk.Box+BoxChild
			this.packageReleaseNotesLabelPaddingEventBox = new global::Gtk.EventBox();
			this.packageReleaseNotesLabelPaddingEventBox.Name = "packageReleaseNotesLabelPaddingEventBox";
			this.packageReleaseNotesLabelVBox.Add(this.packageReleaseNotesLabelPaddingEventBox);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.packageReleaseNotesLabelVBox[this.packageReleaseNotesLabelPaddingEventBox]));
			w25.Position = 1;
			this.mainTable.Add(this.packageReleaseNotesLabelVBox);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageReleaseNotesLabelVBox]));
			w26.TopAttach = ((uint)(15));
			w26.BottomAttach = ((uint)(16));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageReleaseNotesScrolledWindow = new global::Gtk.ScrolledWindow();
			this.packageReleaseNotesScrolledWindow.Name = "packageReleaseNotesScrolledWindow";
			this.packageReleaseNotesScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child packageReleaseNotesScrolledWindow.Gtk.Container+ContainerChild
			this.packageReleaseNotesTextView = new global::Gtk.TextView();
			this.packageReleaseNotesTextView.CanFocus = true;
			this.packageReleaseNotesTextView.Name = "packageReleaseNotesTextView";
			this.packageReleaseNotesTextView.AcceptsTab = false;
			this.packageReleaseNotesTextView.WrapMode = ((global::Gtk.WrapMode)(2));
			this.packageReleaseNotesScrolledWindow.Add(this.packageReleaseNotesTextView);
			this.mainTable.Add(this.packageReleaseNotesScrolledWindow);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageReleaseNotesScrolledWindow]));
			w28.TopAttach = ((uint)(15));
			w28.BottomAttach = ((uint)(16));
			w28.LeftAttach = ((uint)(1));
			w28.RightAttach = ((uint)(2));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageRequireLicenseAcceptanceCheckBox = new global::Gtk.CheckButton();
			this.packageRequireLicenseAcceptanceCheckBox.CanFocus = true;
			this.packageRequireLicenseAcceptanceCheckBox.Name = "packageRequireLicenseAcceptanceCheckBox";
			this.packageRequireLicenseAcceptanceCheckBox.Label = "";
			this.packageRequireLicenseAcceptanceCheckBox.DrawIndicator = true;
			this.packageRequireLicenseAcceptanceCheckBox.UseUnderline = true;
			this.packageRequireLicenseAcceptanceCheckBox.Xalign = 0F;
			this.mainTable.Add(this.packageRequireLicenseAcceptanceCheckBox);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageRequireLicenseAcceptanceCheckBox]));
			w29.TopAttach = ((uint)(11));
			w29.BottomAttach = ((uint)(12));
			w29.LeftAttach = ((uint)(1));
			w29.RightAttach = ((uint)(2));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageRequireLicenseAcceptanceLabel = new global::Gtk.Label();
			this.packageRequireLicenseAcceptanceLabel.Name = "packageRequireLicenseAcceptanceLabel";
			this.packageRequireLicenseAcceptanceLabel.Xalign = 0F;
			this.packageRequireLicenseAcceptanceLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Require License Acceptance:");
			this.mainTable.Add(this.packageRequireLicenseAcceptanceLabel);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageRequireLicenseAcceptanceLabel]));
			w30.TopAttach = ((uint)(11));
			w30.BottomAttach = ((uint)(12));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageSummaryLabel = new global::Gtk.Label();
			this.packageSummaryLabel.Name = "packageSummaryLabel";
			this.packageSummaryLabel.Xalign = 0F;
			this.packageSummaryLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Summary:");
			this.mainTable.Add(this.packageSummaryLabel);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageSummaryLabel]));
			w31.TopAttach = ((uint)(7));
			w31.BottomAttach = ((uint)(8));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageSummaryTextBox = new global::Gtk.Entry();
			this.packageSummaryTextBox.CanFocus = true;
			this.packageSummaryTextBox.Name = "packageSummaryTextBox";
			this.packageSummaryTextBox.IsEditable = true;
			this.packageSummaryTextBox.InvisibleChar = '●';
			this.mainTable.Add(this.packageSummaryTextBox);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageSummaryTextBox]));
			w32.TopAttach = ((uint)(7));
			w32.BottomAttach = ((uint)(8));
			w32.LeftAttach = ((uint)(1));
			w32.RightAttach = ((uint)(2));
			w32.XOptions = ((global::Gtk.AttachOptions)(4));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageTagsLabel = new global::Gtk.Label();
			this.packageTagsLabel.Name = "packageTagsLabel";
			this.packageTagsLabel.Xalign = 0F;
			this.packageTagsLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Tags:");
			this.mainTable.Add(this.packageTagsLabel);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageTagsLabel]));
			w33.TopAttach = ((uint)(13));
			w33.BottomAttach = ((uint)(14));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageTagsTextBox = new global::Gtk.Entry();
			this.packageTagsTextBox.CanFocus = true;
			this.packageTagsTextBox.Name = "packageTagsTextBox";
			this.packageTagsTextBox.IsEditable = true;
			this.packageTagsTextBox.InvisibleChar = '●';
			this.mainTable.Add(this.packageTagsTextBox);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageTagsTextBox]));
			w34.TopAttach = ((uint)(13));
			w34.BottomAttach = ((uint)(14));
			w34.LeftAttach = ((uint)(1));
			w34.RightAttach = ((uint)(2));
			w34.XOptions = ((global::Gtk.AttachOptions)(4));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageTitleLabel = new global::Gtk.Label();
			this.packageTitleLabel.Name = "packageTitleLabel";
			this.packageTitleLabel.Xalign = 0F;
			this.packageTitleLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Title:");
			this.mainTable.Add(this.packageTitleLabel);
			global::Gtk.Table.TableChild w35 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageTitleLabel]));
			w35.TopAttach = ((uint)(5));
			w35.BottomAttach = ((uint)(6));
			w35.XOptions = ((global::Gtk.AttachOptions)(4));
			w35.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageTitleTextBox = new global::Gtk.Entry();
			this.packageTitleTextBox.CanFocus = true;
			this.packageTitleTextBox.Name = "packageTitleTextBox";
			this.packageTitleTextBox.IsEditable = true;
			this.packageTitleTextBox.InvisibleChar = '●';
			this.mainTable.Add(this.packageTitleTextBox);
			global::Gtk.Table.TableChild w36 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageTitleTextBox]));
			w36.TopAttach = ((uint)(5));
			w36.BottomAttach = ((uint)(6));
			w36.LeftAttach = ((uint)(1));
			w36.RightAttach = ((uint)(2));
			w36.XOptions = ((global::Gtk.AttachOptions)(4));
			w36.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageVersionLabel = new global::Gtk.Label();
			this.packageVersionLabel.Name = "packageVersionLabel";
			this.packageVersionLabel.Xalign = 0F;
			this.packageVersionLabel.LabelProp = global::Mono.Unix.Catalog.GetString("Version:");
			this.mainTable.Add(this.packageVersionLabel);
			global::Gtk.Table.TableChild w37 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageVersionLabel]));
			w37.TopAttach = ((uint)(1));
			w37.BottomAttach = ((uint)(2));
			w37.XOptions = ((global::Gtk.AttachOptions)(4));
			w37.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child mainTable.Gtk.Table+TableChild
			this.packageVersionTextBox = new global::Gtk.Entry();
			this.packageVersionTextBox.CanFocus = true;
			this.packageVersionTextBox.Name = "packageVersionTextBox";
			this.packageVersionTextBox.IsEditable = true;
			this.packageVersionTextBox.InvisibleChar = '●';
			this.mainTable.Add(this.packageVersionTextBox);
			global::Gtk.Table.TableChild w38 = ((global::Gtk.Table.TableChild)(this.mainTable[this.packageVersionTextBox]));
			w38.TopAttach = ((uint)(1));
			w38.BottomAttach = ((uint)(2));
			w38.LeftAttach = ((uint)(1));
			w38.RightAttach = ((uint)(2));
			w38.XOptions = ((global::Gtk.AttachOptions)(4));
			w38.YOptions = ((global::Gtk.AttachOptions)(4));
			this.Add(this.mainTable);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.Hide();
		}
	}
}
