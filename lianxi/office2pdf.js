var converter = require('office-converter')();
  converter.generatePdf('book1.xlsx', function(err, result) {
    // Process result if no error
    if (result.status === 0) {
      console.log('Output File located at ' + result.outputFile);
    }
  });
  converter.generateHtml('vim.docx', function(err, result) {
    // Process result if no error
    if (result.status === 0) {
      console.log('Output File located at ' + result.outputFile);
    }
  });