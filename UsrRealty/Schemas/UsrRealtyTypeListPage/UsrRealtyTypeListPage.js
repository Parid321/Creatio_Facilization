define("UsrRealtyTypeListPage", /**SCHEMA_DEPS*/[]/**SCHEMA_DEPS*/, function/**SCHEMA_ARGS*/()/**SCHEMA_ARGS*/ {
	return {
		viewConfigDiff: /**SCHEMA_VIEW_CONFIG_DIFF*/[
			{
				"operation": "insert",
				"name": "DataGrid_8g1y2nd",
				"values": {
					"layoutConfig": {
						"column": 1,
						"colSpan": 10,
						"row": 1,
						"rowSpan": 12
					},
					"type": "crt.DataGrid",
					"features": {
						"rows": {
							"selection": {
								"enable": true,
								"multiple": true
							}
						}
					},
					"items": "$DataGrid_8g1y2nd",
					"visible": true,
					"fitContent": true,
					"primaryColumnName": "DataGrid_8g1y2ndDS_Id",
					"columns": [
						{
							"id": "d1c6298b-fdec-130b-6d9e-6f7ef3c08752",
							"code": "DataGrid_8g1y2ndDS_Name",
							"caption": "#ResourceString(DataGrid_8g1y2ndDS_Name)#",
							"dataValueType": 28
						},
						{
							"id": "842f4cec-daba-8a32-013d-e57012805a01",
							"code": "DataGrid_8g1y2ndDS_Name",
							"caption": "#ResourceString(DataGrid_8g1y2ndDS_Name)#",
							"dataValueType": 28
						},
						{
							"id": "8c697e63-1bc9-a7b1-b208-3d113247ab03",
							"code": "DataGrid_8g1y2ndDS_UsrMyColor",
							"caption": "#ResourceString(DataGrid_8g1y2ndDS_UsrMyColor)#",
							"dataValueType": 18
						},
						{
							"id": "e91be77c-a8f6-683e-d5dc-3b9cb0e44e26",
							"code": "DataGrid_8g1y2ndDS_Description",
							"caption": "#ResourceString(DataGrid_8g1y2ndDS_Description)#",
							"dataValueType": 28
						}
					],
					"placeholder": false
				},
				"parentName": "TopAreaProfileContainer",
				"propertyName": "items",
				"index": 0
			}
		]/**SCHEMA_VIEW_CONFIG_DIFF*/,
		viewModelConfigDiff: /**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [
					"attributes"
				],
				"values": {
					"DataGrid_8g1y2nd": {
						"isCollection": true,
						"modelConfig": {
							"path": "DataGrid_8g1y2ndDS"
						},
						"viewModelConfig": {
							"attributes": {
								"DataGrid_8g1y2ndDS_Name": {
									"modelConfig": {
										"path": "DataGrid_8g1y2ndDS.Name"
									}
								},
								"DataGrid_8g1y2ndDS_UsrMyColor": {
									"modelConfig": {
										"path": "DataGrid_8g1y2ndDS.UsrMyColor"
									}
								},
								"DataGrid_8g1y2ndDS_Description": {
									"modelConfig": {
										"path": "DataGrid_8g1y2ndDS.Description"
									}
								},
								"DataGrid_8g1y2ndDS_Id": {
									"modelConfig": {
										"path": "DataGrid_8g1y2ndDS.Id"
									}
								}
							}
						}
					}
				}
			}
		]/**SCHEMA_VIEW_MODEL_CONFIG_DIFF*/,
		modelConfigDiff: /**SCHEMA_MODEL_CONFIG_DIFF*/[
			{
				"operation": "merge",
				"path": [],
				"values": {
					"dataSources": {
						"DataGrid_8g1y2ndDS": {
							"type": "crt.EntityDataSource",
							"scope": "viewElement",
							"config": {
								"entitySchemaName": "UsrRealtyType",
								"attributes": {
									"Name": {
										"path": "Name"
									},
									"UsrMyColor": {
										"path": "UsrMyColor"
									},
									"Description": {
										"path": "Description"
									}
								}
							}
						}
					}
				}
			}
		]/**SCHEMA_MODEL_CONFIG_DIFF*/,
		handlers: /**SCHEMA_HANDLERS*/[]/**SCHEMA_HANDLERS*/,
		converters: /**SCHEMA_CONVERTERS*/{}/**SCHEMA_CONVERTERS*/,
		validators: /**SCHEMA_VALIDATORS*/{}/**SCHEMA_VALIDATORS*/
	};
});