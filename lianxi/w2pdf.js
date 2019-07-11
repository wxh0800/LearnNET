const word2pdf = require('word2pdf');
const fs = require('fs');

const convert = async() => {
    const data = await word2pdf('vim.docx')
    fs.writeFileSync('test.pdf', data)
}

convert();

