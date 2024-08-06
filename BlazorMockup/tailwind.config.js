/** @type {import('tailwindcss').Config} */
module.exports = {
    content: [
        "./Pages/**/*.razor",
        "./Shared/**/*.razor",
        "./wwwroot/**/*.html",
        "./**/*.cshtml",
    ],
  theme: {
    extend: {
      fontFamily:{
        'neo-sans': ['Neo Sans Std', 'sans serif'],
      }
    },
    fonts: {
      neoSansStd: ['../fonts/NeoSansStd-Regular.woff', '../fonts/NeoSansStd-Regular.woff2'],
    }
  },
  plugins: [],
}