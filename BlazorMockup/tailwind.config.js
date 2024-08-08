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
      backgroundColor: {
        'custom-green': '#32947C',
         'custom-green-hover': 'rgba(50, 148, 124, 0.08)'
      },
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